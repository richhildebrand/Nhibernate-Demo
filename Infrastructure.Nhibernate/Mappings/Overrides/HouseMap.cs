using Demo.Core.Models;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace Demo.Infrastructure.Nhibernate.Mappings.Overrides
{
    public class HouseMap : IAutoMappingOverride<House>
    {
        public void Override(AutoMapping<House> mapping)
        {
            mapping.Table("House");
            mapping.Id(x => x.House_Id);
        }
    }
}