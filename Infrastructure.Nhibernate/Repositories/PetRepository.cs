using Demo.Core.Models;
using NHibernate;

namespace Demo.Infrastructure.Nhibernate.Repositories
{
    public class PetRepository
    {
        private readonly ISessionFactory _sessionFactory;

        public PetRepository(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        public void Save(Pet pet)
        {
            using (ISession session = _sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(pet);
                    transaction.Commit();
                }
            }
        }
    }
}
