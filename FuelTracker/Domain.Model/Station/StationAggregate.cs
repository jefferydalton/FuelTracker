using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.DDS.FuelTracker.Domain.Model.Station
{
    public class StationAggregate : Entity
    {
        private StationAggregate() : base() { }

        internal StationAggregate(StationId aStationId,
                                  String aStationName) : base()
        {
            this.Id = aStationId;
            this.StationName = aStationName;
        }

        public StationId Id { get; private set; }

        public string StationName {
            get { return name; }
            private set
            {
                this.AssertArgumentNotEmpty(value, "Cannot use Null as StationName");
                this.name = value;
            }
        }
        private string name;

        public void ChangeStationName(string newStationName)
        {
            this.StationName = newStationName;
        }
    }
}
