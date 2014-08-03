using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.DDS.FuelTracker.Domain.Model.Station
{
    public class StationAggregate
    {
        private StationAggregate() { }

        internal StationAggregate(StationId id)
        {
            this.Id = id;
        }

        public StationId Id { get; private set; }

    }
}
