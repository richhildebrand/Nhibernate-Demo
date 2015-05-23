using System;
using Demo.Core.Interfaces;
using FluentNHibernate.Automapping;

namespace Demo.Infrastructure.Nhibernate.Configurations
{
    public class AutomappingConfiguration : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            var persitentType = typeof(IPersistentModel);
            return persitentType.IsAssignableFrom(type);
        }
    }
}
