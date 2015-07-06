using Demo.Core.Models;
using Demo.Infrastructure.Nhibernate;
using Demo.Infrastructure.Nhibernate.Repositories;
using Demo.IntegrationTests.TestHelpers;
using NHibernate.Event;
using NUnit.Framework;
using Should;

namespace Demo.IntegrationTests.RepositoryTests
{
    [TestFixture]
    public class GetShould
    {
        private Repository _repository;

        [SetUp]
        public void SetUp()
        {
            _repository = new Repository(DatabaseContext.SessionFactory);
        }

        [Test]
        public void GetPersonAndHouse()
        {
            var house = ModelCreator.CreateHouse(ModelCreator.IdNotSet);
            _repository.Save<House>(house);

            var person = ModelCreator.CreatePerson(ModelCreator.IdNotSet, house.Id);
            _repository.Save<Person>(person);

            var personFromDb = _repository.Get<Person>(person.Id);
            personFromDb.Id.ShouldEqual(person.Id);
            personFromDb.House.Id.ShouldEqual(house.Id);
        }

    }
}
