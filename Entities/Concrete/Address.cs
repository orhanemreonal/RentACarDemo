using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Address : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string TypeName { get; set; }
        public string Country { get; set; } 
        public string City { get; set; }   
        public string District { get; set; }
        public string Neighbourhood { get; set; }
        public string Street { get; set; }
        public string DoorNumber { get; set; }
        public string Description { get; set; }
        public Customer Customer { get; set; }

    }
}
