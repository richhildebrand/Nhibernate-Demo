using System;
using Demo.Core.Interfaces;

namespace Demo.Core.Models
{
    public class Pet
    {
        public virtual Guid Pet_Id { get; set; }
        public virtual string Name { get; set; }
    }
}