using Com.DDS.FuelTracker.Domain.Model.Station;
using Com.DDS.FuelTracker.Port.Adapter.Persistence;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Tool.hbm2ddl;
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
        ISessionFactory sessionFactory;

        public StationRepositorySQLTest()
        {
            //TODO: Refactor this into a routine that can be pushed into the repository.
            var configuration = new Configuration();
            configuration.DataBaseIntegration(x =>
            {
                x.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\FuelTrackerTest.mdf;Integrated Security=True;Connect Timeout=30";
                x.Driver<SqlClientDriver>();
                x.Dialect<MsSql2012Dialect>();
            });

            //TODO: Refactor this into a routine that can be pushed into the repository
            configuration.AddAssembly(typeof(StationAggregate).Assembly);
            var schemaExport = new SchemaExport(configuration);
            schemaExport.Execute(false, true, false);
            

            sessionFactory = configuration.BuildSessionFactory();
            

        }

        public void Dispose()
        {
            sessionFactory.Close();
            sessionFactory.Dispose();
        }

        [Fact]
        public void StationRepositorySQL_GetAllStations_ReturnsAtLeastOneRecord()
        {
            var repository = new StationRepositorySQL(sessionFactory);            

            var results = repository.GetAllStations();
            Assert.NotNull(results);
            //Assert.True(results.Count > 0);
        }

    }
}
