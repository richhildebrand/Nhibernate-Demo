using Demo.Core.Models;

namespace Demo.Core.Helper
{
    public class PersonHelper
    {
        private readonly Person _person;

        public PersonHelper(Person person)
        {
            _person = person;
        }

        public string GetFullName()
        {
            return _person.FirstName + " " + _person.LastName;
        }
    }
}
