// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

CarManager carManager = new CarManager(new EfCarDal());

var result= carManager.GetCarDetails();
if (result.Success)
{
    foreach (var car in result.Data)
    {
        Console.WriteLine(car.CarName + " - " + car.BrandName + " - " + car.ColorName + " - " + car.DailyPrice + " TL");
    }
}
else
{
    Console.WriteLine(result.Message);
}