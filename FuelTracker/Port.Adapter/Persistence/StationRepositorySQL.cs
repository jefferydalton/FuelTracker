using Com.DDS.FuelTracker.Domain.Model.Station;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.DDS.FuelTracker.Port.Adapter.Persistence
{
    public class StationRepositorySQL : AbstractHibernateSession, IStationRepository
    {
        private StationRepositorySQL() :base(null)
        {
        }

        public StationRepositorySQL(ISessionFactory aSessionFactory) :base(aSessionFactory)
        {
        }

        public IReadOnlyList<StationBase> GetAllStations()
        {
            using (ISession session = this.OpenSession())
                return session.Query<StationBase>().ToList().AsReadOnly();
        }

        public StationBase GetStationOfId(Guid aId)
        {
            throw new NotImplementedException();
        }

        public StationBase GetStationOfName(string aName)
        {
            throw new NotImplementedException();
        }

        public void AddStation(StationBase aStation)
        {

        }

        public void SaveStation(StationAggregate aStation)
        {
            
        }

        public void RemoveStation(StationAggregate aStation)
        {
            throw new NotImplementedException();
        }
    }
}
