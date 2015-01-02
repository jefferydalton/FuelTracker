using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.DDS.FuelTracker.Domain.Model.Station
{
    public interface IStationRepository
    {
        IReadOnlyList<StationBase> GetAllStations();

        StationBase GetStationOfId(Guid aId);

        StationBase GetStationOfName(string aName);

        void SaveStation(StationBase aStation);

        void AddStation(StationBase aStation);

        void RemoveStation(StationBase aStation);
    }
}
