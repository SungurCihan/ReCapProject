using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            //BrandTest();

            //ColorTest();

            //UserTest();

            //CustomerTest();

            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            Rental rental1 = new Rental { Id = 1, CarId = 1, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = null} ;
            Rental rental2 = new Rental { Id = 2, CarId = 2, CustomerId = 2, RentDate = DateTime.Now, ReturnDate = null };
            Rental rental3 = new Rental { Id = 3, CarId = 5, CustomerId = 3, RentDate = DateTime.Now, ReturnDate = null };
            Rental rental4 = new Rental { Id = 4, CarId = 1, CustomerId = 2, RentDate = DateTime.Now, ReturnDate = null };



            foreach (var rental in rentalManager.GetRentalDetails().Data)
            {
                Console.WriteLine(rental.CustomerCompanyName);
            }
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            Customer customer1 = new Customer { Id = 1, UserId = 1, CompanyId = 1 };
            Customer customer2 = new Customer { Id = 2, UserId = 2, CompanyId = 2 };
            Customer customer3 = new Customer { Id = 3, UserId = 3, CompanyId = 3 };


            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.CompanyId);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            User user1 = new User { Id = 1, FirstName = "Sungur", LastName = "Cihan", Email = "nsc1169@gmail.com", Password = "Sungur123" };
            User user2 = new User { Id = 2, FirstName = "Burak", LastName = "Karkin", Email = "kar-kinburak@hotmail.com", Password = "qrqn123" };
            User user3 = new User { Id = 3, FirstName = "Mahmut", LastName = "Tayamaz", Email = "tayMayanMahMut@gmail.com", Password = "Taygül123" };


            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.LastName);
            }

            Console.WriteLine(userManager.Get(u => u.Id == 3).Data.FirstName);
            Console.WriteLine(userManager.Get(u => u.Id == 3).Success);
            Console.WriteLine(userManager.Get(u => u.Id == 3).Message);
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Color color1 = new Color { ColorId = 1, ColorName = "Siyah" };
            Color color2 = new Color { ColorId = 3, ColorName = "Kırmızı" };
            Color color3 = new Color { ColorId = 4, ColorName = "Beyaz" };


            //Console.WriteLine(colorManager.Get(c => c.ColorId == 1).ColorName);

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Brand brand1 = new Brand { BrandId = 1, BrandName = "Audi" };
            Brand brand2 = new Brand { BrandId = 2, BrandName = "Renault" };


            //Console.WriteLine(brandManager.Get(b => b.BrandId == 1).BrandName);

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car1 = new Car { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 200, ModelYear = "2014", CarDescription = "Is görür" };
            Car car2 = new Car { CarId = 2, BrandId = 2, ColorId = 3, DailyPrice = 400, ModelYear = "2017", CarDescription = "Deneme" };
            Car car3 = new Car { CarId = 3, BrandId = 2, ColorId = 4, DailyPrice = 600, ModelYear = "2019", CarDescription = "Süper bir araba" };


            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.CarId);
            }
        }
    }
}
