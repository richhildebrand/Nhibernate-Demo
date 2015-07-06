using Demo.Core.Interfaces;

namespace Demo.Core.Models
{
    public class Person : IPersistentModel
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual House House { get; set; }
    }
}
