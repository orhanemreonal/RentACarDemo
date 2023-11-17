using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        //FuelTest();





    }
    static void FuelTest()
    {
        FuelManager fuelManager = new FuelManager(new EfFuelDal());

        Fuel fuel = new Fuel
        {
            Type = "T"

        };

        var result = fuelManager.Add(fuel);
        Console.WriteLine(result.Message);
    }
}