using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car :IEntity
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public decimal Price { get; set; } 
        public bool IsAvailable { get; set; }
        public string PlateNumber { get; set; }
        public Model Model { get; set; }
        public Rental Rental { get; set; }
    }
}
