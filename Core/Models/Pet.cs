using System;
using Demo.Core.Interfaces;

namespace Demo.Core.Models
{
    public class Pet : IPersistentModel
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
    }
}