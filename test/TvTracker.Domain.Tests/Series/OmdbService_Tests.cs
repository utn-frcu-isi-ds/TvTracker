﻿using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Modularity;
using Xunit;

namespace TvTracker.Series
{
    public abstract class OmdbService_Tests<TStartupModule> : TvTrackerDomainTestBase<TStartupModule> where TStartupModule : IAbpModule
    {
        private readonly OmdbService _service;

        public OmdbService_Tests()
        {
            _service = new OmdbService();
        }

        [Fact]
        public async Task Should_Search_One_Serie()
        {
            //Arrange
            var title = "Game of Thrones";

            //Act
            var result = await _service.GetSeriesAsync(title, String.Empty);

            //Assert
            result.Count.ShouldBeGreaterThan(0);
            result.ShouldContain(b => b.Title == title);
        }

        [Fact]
        public async Task Should_Search_None_Serie()
        {
            //Arrange
            var title = "ufyffflflffñfñififiy";

            //Act
            var result = await _service.GetSeriesAsync(title, String.Empty);

            //Assert
            result.Count.ShouldBe(0);            
        }
    }
}
