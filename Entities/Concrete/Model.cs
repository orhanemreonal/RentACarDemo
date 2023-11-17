using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Model:IEntity
    {
        public int Id { get; set; }
        public int FuelId { get; set; }
        public int GearId { get; set; }
        public int BodyId { get; set; } 
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public Fuel Fuel { get; set; }
        public Gear Gear { get; set; }
        public Body Body { get; set; }
        public Brand Brand { get; set; }

    }
}
