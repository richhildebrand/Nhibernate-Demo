using Demo.Core.Models;
using NHibernate;

namespace Demo.Infrastructure.Nhibernate.Repositories
{
    public class PersonRepository
    {
        private readonly ISessionFactory _sessionFactory;

        public PersonRepository(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        public void Save(Person person)
        {
            using (ISession session = _sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(person);
                    transaction.Commit();
                }
            }
        }
    }
}
