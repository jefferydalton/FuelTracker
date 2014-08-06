using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.DDS.FuelTracker.Domain.Model.Station
{
    public interface IStationRepository
    {
        StationId NextIdentity();

        List<StationAggregate> AllStations();

        void Save(StationAggregate aStation);
    }
}
