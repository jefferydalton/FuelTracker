using System;
using System.Text;
using System.Collections.Generic;
using Xunit;

namespace Com.DDS.FuelTracker.Tests.Domain.Model.Station
{
    /// <summary>
    /// Summary description for StationTest
    /// </summary>
    public class StationTest
    {
        public StationTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [Fact]
        public void Station_IdWithZeroThrowsException()
        {
            Exception ex = Assert.Throws<ArgumentException>(() => new FuelTracker.Domain.Model.Station.StationId(0));
        }

        [Fact]
        public void Station_IdCreatedCorrectly()
        {
            var result = new FuelTracker.Domain.Model.Station.StationId(10);
            Assert.Equal((Int32)10, result.Value);
        }


        [Fact]
        public void Station_AggregateCreatedCorrectly()
        {
            var testID = new FuelTracker.Domain.Model.Station.StationId(10);
            var testName = "Test Name";
            var result = new FuelTracker.Domain.Model.Station.StationAggregate(testID,
                                                                               testName);
            Assert.NotNull(result);
            Assert.True(result.StationName == testName);
            Assert.True(result.ConcurrencyVersion == 0);
            Assert.Equal(testID, result.Id);
        }

        [Fact]
        public void Station_AggregateCreateInvalid_EmptyName()
        {
            var testID = new FuelTracker.Domain.Model.Station.StationId(10);
            var testName = string.Empty;
            Exception ex = Assert.Throws<ArgumentException>(() => new FuelTracker.Domain.Model.Station.StationAggregate(testID, testName));
        }

    }
}
