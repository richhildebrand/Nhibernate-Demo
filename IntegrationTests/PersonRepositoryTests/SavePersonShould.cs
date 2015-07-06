//using Demo.Core.Models;
//using Demo.Infrastructure.Nhibernate;
//using Demo.Infrastructure.Nhibernate.Repositories;
//using Demo.IntegrationTests.TestHelpers;
//using NUnit.Framework;
//using Should;

//namespace Demo.IntegrationTests.PersonRepositoryTests
//{
//    [TestFixture]
//    public class SavePersonShould
//    {
//        private Repository _repository;

//        [SetUp]
//        public void SetUp()
//        {
//            _repository = new Repository(DatabaseContext.SessionFactory);
//        }

//        [Test]
//        public void Save()
//        {
//            var houseId = CreateAndSaveHouse();

//            const int idNotSet = 0;
//            var person = new Person
//            {
//                Person_Id = idNotSet,
//                FirstName = "Bernie",
//                LastName = "Kosar",
//                FK_House_Id = houseId,
//            };

//            _repository.Save<Person>(person);

//            person.Person_Id.ShouldNotEqual(idNotSet);
//        }
//        private int CreateAndSaveHouse()
//        {
//            var house = ModelCreator.CreateHouse(ModelCreator.IdNotSet);
//            _repository.Save<House>(house);
//            return house.House_Id;
//        }
//    }
//}
