﻿using Demo.Core.Models;
using Demo.Infrastructure.Nhibernate;
using Demo.Infrastructure.Nhibernate.Repositories;
using Demo.IntegrationTests.TestHelpers;
using NUnit.Framework;
using Should;

namespace Demo.IntegrationTests.RepositoryTests
{
    [TestFixture]
    public class SaveShould
    {
        private Repository _repository;

        [SetUp]
        public void SetUp()
        {
            _repository = new Repository(DatabaseContext.SessionFactory);
        }

        [Test]
        public void SaveHouses()
        {
            var house = ModelCreator.CreateHouse(ModelCreator.IdNotSet);
            _repository.Save<House>(house);
            house.Id.ShouldNotEqual(ModelCreator.IdNotSet);
        }

        [Test]
        public void SavePerson()
        {
            var house = ModelCreator.CreateHouse(ModelCreator.IdNotSet);
            _repository.Save<House>(house);

            var person = ModelCreator.CreatePerson(ModelCreator.IdNotSet, house.Id);
            _repository.Save<Person>(person);

            person.Id.ShouldNotEqual(ModelCreator.IdNotSet);
            person.House.Id.ShouldEqual(house.Id);
        }
    }
}
