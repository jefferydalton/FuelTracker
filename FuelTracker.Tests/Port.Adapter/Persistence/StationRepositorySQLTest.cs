using Com.DDS.FuelTracker.Domain.Model.Station;
using Com.DDS.FuelTracker.Port.Adapter.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Com.DDS.FuelTracker.Tests.Port.Adapter.Persistence
{
    
    public class StationRepositorySQLTest : IDisposable
    {

        public StationRepositorySQLTest()
        {
           
        }

        [Fact]
        public void StationRepositorySQL_NextIdentity_Returns_Zero()
        {
            IStationRepository repository = new StationRepositorySQL();
            var identity = repository.NextIdentity();
            Assert.Equal(identity.Value, 10);
        }
        public void Dispose()
        {
        }
    }
}
