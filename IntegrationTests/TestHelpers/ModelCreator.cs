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
                Id = id,
                Address = "100 Alfred Lerner Way",
                City = "Cleveland",
                State = "OH",
                ZipCode = "44114"
            };
        }

        public static Person CreatePerson(int id, int houseId)
        {
            return new Person
            {
                Id = id,
                FirstName = "Bernie",
                LastName = "Kosar",
                House = CreateHouse(houseId),
            };
        }
    }
}
