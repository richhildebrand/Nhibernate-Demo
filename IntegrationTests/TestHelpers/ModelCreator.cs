using Demo.Core.Models;

namespace Demo.IntegrationTests.TestHelpers
{
    public static class ModelCreator
    {
        public static readonly int IdNotSet = 0;

        public static House CreateHouse(int id)
        {
            return new House
            {
                House_Id = id,
                Address = "100 Alfred Lerner Way",
                City = "Cleveland",
                State = "OH",
                ZipCode = "44114"
            };
        }
    }
}
