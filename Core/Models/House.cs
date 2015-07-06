using Demo.Core.Interfaces;

namespace Demo.Core.Models
{
    public class House : IPersistentModel
    {
        public virtual int Id { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string ZipCode { get; set; }
    }
}
