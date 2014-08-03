using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelTracker.Extensions;

namespace FuelTracker.Domain.Model.Station
{
    public class StationId
    {

        private StationId() { }

        internal StationId(Int32 id)
        {
            this.Id = id;
        }

        internal StationId(StationId id)
        {
            this.Id = id.Id;
        }

        public Int32 Id
        {
            get
            {
                return id;
            }
            private set
            {
                value.AssertValueNotZero("The Id must be provided.");
                this.id = value;
            }
        }
        private Int32 id;
    }
}
