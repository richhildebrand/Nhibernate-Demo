using Demo.Core.Models;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace Demo.Infrastructure.Nhibernate.Mappings.Overrides
{
    public class PetMap : IAutoMappingOverride<Pet>
    {
        public void Override(AutoMapping<Pet> mapping)
        {
            mapping.Table("Pets");
            mapping.Id(x => x.Pet_Id).GeneratedBy.Assigned();
            mapping.Map(x => x.Name).Column("PetName");
        }
    }
}