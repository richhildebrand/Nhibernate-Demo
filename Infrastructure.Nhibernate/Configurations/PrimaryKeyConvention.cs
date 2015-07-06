using System;
using Demo.Core.Interfaces;
using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace Demo.Infrastructure.Nhibernate.Configurations
{
    public class PrimaryKeyConvention : IIdConvention
    {
        public void Apply(IIdentityInstance instance)
        {
            Type type = instance.EntityType;
            var persitentType = typeof(IPersistentModel);
            var isMappableModel = persitentType.IsAssignableFrom(type);

            if (isMappableModel)
            {
                instance.Column(type.Name + "_Id");
                instance.GeneratedBy.Native();
            }
        }
    }
}
