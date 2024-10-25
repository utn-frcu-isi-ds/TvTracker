﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.BackgroundWorkers;
using Volo.Abp.Threading;
using Volo.Abp.Users;

namespace TvTracker.Series
{
    public class SerieModificationCheckerWorker : AsyncPeriodicBackgroundWorkerBase
    {
        public SerieModificationCheckerWorker(
                AbpAsyncTimer timer,
                IServiceScopeFactory serviceScopeFactory
            ) : base(
                timer,
                serviceScopeFactory)
        {
            Timer.Period = 600000; //10 minutes
        }

        protected async override Task DoWorkAsync(
            PeriodicBackgroundWorkerContext workerContext)
        {
            Logger.LogInformation("Starting: Setting status of inactive users...");

            //Resolve dependencies
            var userRepository = workerContext
                .ServiceProvider
                .GetRequiredService<IUserRepository>();

            //Do the work
            await userRepository.UpdateInactiveUserStatusesAsync();

            Logger.LogInformation("Completed: Setting status of inactive users...");
        }
    }
}
