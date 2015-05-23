using System;
using Demo.Infrastructure.Nhibernate;
using NUnit.Framework;
using Should;

namespace Demo.IntegrationTests.DatabaseContextTests
{
    [TestFixture]
    public class GetSqlConfigurationShould
    {
        [Test]
        public void ReturnSqlConfiguration_WhenGivenValidKey()
        {
            var sqlConfig = DatabaseContext.GetSqlConfiguration("DatabaseConnectionString");
            sqlConfig.ShouldNotBeNull();
        }

        [Test]
        public void Throw_WhenGivenBadKey()
        {
            var testDelegate = new TestDelegate(TryWithBadKey);
            Assert.Throws<NullReferenceException>(testDelegate);
        }

        public void TryWithBadKey()
        {
            var sqlConfig = DatabaseContext.GetSqlConfiguration("BadKey");
            sqlConfig.ShouldBeNull();
        }
    }
}
