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
        public void Station_AggregateCreatedCorrectly()
        {
            var testID = Guid.NewGuid();
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
            var testID = Guid.NewGuid();
            var testName = string.Empty;
            Exception ex = Assert.Throws<ArgumentException>(() => new FuelTracker.Domain.Model.Station.StationAggregate(testID, testName));
        }

    }
}
