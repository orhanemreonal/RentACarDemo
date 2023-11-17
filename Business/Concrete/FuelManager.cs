using Business.Abstract;
using Core.Utilities.Results;
using Core.Utilities.Results.ResultTypes;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FuelManager : IFuelService
    {
        IFuelDal _fuelDal;

        public FuelManager(IFuelDal fuelDal)
        {
            _fuelDal = fuelDal;
        }

        public IResult Add(Fuel fuel)
        {
            if (fuel.Type.Length < 2)
            {
                return new ErrorResult("Eklenmedi");
            }
            else
            {
                _fuelDal.Add(fuel);
                return new SuccessResult("Eklendi");
                

            }
            
        }
    }
}
