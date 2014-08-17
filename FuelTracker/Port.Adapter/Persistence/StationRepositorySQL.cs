using Com.DDS.FuelTracker.Domain.Model.Station;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.DDS.FuelTracker.Port.Adapter.Persistence
{
    public class StationRepositorySQL : IStationRepository
    {
        public StationId NextIdentity()
        {
            return new StationId(10);
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
