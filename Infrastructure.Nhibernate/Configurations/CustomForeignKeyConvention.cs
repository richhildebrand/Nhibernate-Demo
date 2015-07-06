using System;
using FluentNHibernate;
using FluentNHibernate.Conventions;

namespace Demo.Infrastructure.Nhibernate.Configurations
{
    public class CustomForeignKeyConvention : ForeignKeyConvention
    {
        protected override string GetKeyName(Member property, Type type)
        {
            if (property == null)
            {
                return "";
            }

            return "FK_" + property.Name + "_Id";
        }
    }
}
