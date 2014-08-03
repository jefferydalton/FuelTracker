using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Com.DDS.FuelTracker.Domain.Model.Station
{
    public class StationId : ValueObject
    {

        private StationId() :base() { }

        internal StationId(Int32 id) :base() 
        {
            this.Value = id;
        }

        internal StationId(StationId id) :base()
        {
            this.Value = id.Value;
        }

        public Int32 Value
        {
            get
            {
                return id;
            }
            private set
            {
                this.AssertArgumentFalse(value == 0, "The Id must be provided.");
                this.id = value;
            }
        }
        private Int32 id;
    }
}
