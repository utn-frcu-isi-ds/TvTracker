﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvTracker.EntityFrameworkCore;
using Xunit;

namespace TvTracker.Series
{
    [Collection(TvTrackerTestConsts.CollectionDefinitionName)]
    public class EfCoreOmdbService_Tests : OmdbService_Tests<TvTrackerEntityFrameworkCoreTestModule>
    {
    }
}
