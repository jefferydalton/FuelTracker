using Com.DDS.FuelTracker.Domain.Model.Station;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.DDS.FuelTracker.Port.Adapter.Persistence
{
    public class InMemoryStationRepository : IStationRepository
    {
        public StationId NextIdentity()
        {
            return new StationId(new Random().Next(int.MinValue, int.MaxValue));
        }

        public List<StationAggregate> AllStations()
        {
            throw new NotImplementedException();
        }

        public void Save(StationAggregate aStation)
        {
            throw new NotImplementedException();
        }
    }
}
