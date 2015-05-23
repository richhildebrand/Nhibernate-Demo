using Demo.Core.Models;
using Demo.Infrastructure.Nhibernate;
using Demo.Infrastructure.Nhibernate.Repositories;
using NUnit.Framework;
using Should;

namespace Demo.IntegrationTests.PersonRepositoryTests
{
    [TestFixture]
    public class SavePersonShould
    {
        [Test]
        public void Save()
        {
            var personRepository = new PersonRepository(DatabaseContext.SessionFactory);

            const int idNotSet = 0;
            var person = new Person
            {
                Id = idNotSet,
                FirstName = "Bernie",
                LastName = "Kosar",
            };

            personRepository.Save(person);

            person.Id.ShouldNotEqual(idNotSet);
        }
    }
}
