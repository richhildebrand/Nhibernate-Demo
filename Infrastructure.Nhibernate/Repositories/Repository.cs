using Demo.Core.Models;
using NHibernate;

namespace Demo.Infrastructure.Nhibernate.Repositories
{
    public class Repository
    {
        private readonly ISessionFactory _sessionFactory;

        public Repository(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        public T Get<T>(int id)
        {
            using (ISession session = _sessionFactory.OpenSession())
            {
                return session.Get<T>(id);
            }
        }

        public void Save<T>(object objectToSave)
        {
            using (ISession session = _sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(objectToSave);
                    transaction.Commit();
                }
            }
        }
    }
}
