using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //First();
          //  CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //foreach (var customer in customerManager.GetAll())
            //{
              //Console.WriteLine(customer);
           //}

        }

        private static void BrandManager()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            // brandManager.Add(new Brand { BrandId = 1, BrandName = "Audi" });
         //   foreach (var brand in brandManager.GetAll())
           // {
             //   Console.WriteLine(brand.BrandName + " " + brand.BrandId);
            //}
        }

        private static void ColorManager()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //  colorManager.Add(new Color { ColorId=1,ColorName = "Kırmızı" });
            // colorManager.Add(new Color { ColorId = 2, ColorName = "Sarı" });

           // foreach (var color in colorManager.GetAll())
            //{
              //  Console.WriteLine(color.ColorName);
            //}
        }

        private static void CarManager()
        {
            CarManager carManager = new CarManager(new EfCarDal());



            // carManager.Add(new Car {ModelName="Ford", BrandId = 1, ColorId = 1, DailyPrice = 500, ModelYear = 2015, Description = "Renault" });
          //  foreach (var car in carManager.GetAll())
            //{
              //  Console.WriteLine(car.ModelName + " " + car.Id);
            //}
        }

        private static void First()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetAll();
            
            if (result.Success == true)
            {
                foreach (var car in customerManager.GetAll().Data)
                {
                    Console.WriteLine(car.CustomerId);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
