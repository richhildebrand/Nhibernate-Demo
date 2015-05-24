using System;
using Demo.Core.Models;
using Demo.Infrastructure.Nhibernate;
using Demo.Infrastructure.Nhibernate.Repositories;
using NUnit.Framework;
using Should;

namespace Demo.IntegrationTests.PetRepositoryTests
{
    [TestFixture]
    public class SavePetShould
    {
        [Test]
        public void Save()
        {
            var petId = Guid.NewGuid();
            var petRepository = new PetRepository(DatabaseContext.SessionFactory);

            var pet = new Pet
            {
                Id = petId,
                Name = "Dawg Pound"
            };

            petRepository.Save(pet);

            pet.Id.ShouldEqual(petId);
        }
    }
}
