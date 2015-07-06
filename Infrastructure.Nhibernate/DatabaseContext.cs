using Demo.Core.Models;
using Demo.Infrastructure.Nhibernate.Configurations;
using Demo.Infrastructure.Nhibernate.Mappings.Overrides;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;

namespace Demo.Infrastructure.Nhibernate
{
    public static class DatabaseContext
    {
        private static ISessionFactory _sessionFactory;
        public static ISessionFactory SessionFactory
        {
            get { return _sessionFactory; }
        }

        static DatabaseContext()
        {
            InitializeSessionFactory();
        }

        private static void InitializeSessionFactory()
        {
            Configuration configuration = BuildConfiguration();
            _sessionFactory = configuration.BuildSessionFactory();
        }

        private static Configuration BuildConfiguration()
        {
            return Fluently.Configure()
                .Database(GetSqlConfiguration("DatabaseConnectionString"))
                .Mappings(m => m.AutoMappings
                        .Add(AutoMap.AssemblyOf<House>(new AutomappingConfiguration())
                        .UseOverridesFromAssemblyOf<HouseMap>()
                        .Conventions.Add(new PrimaryKeyConvention())
                    )
                )
                .BuildConfiguration();
        }

        public static MsSqlConfiguration GetSqlConfiguration(string databaseConnectionStringKey)
        {
            return MsSqlConfiguration.MsSql2012
                .ConnectionString(c => c.FromConnectionStringWithKey(databaseConnectionStringKey));
        }
    }
}
