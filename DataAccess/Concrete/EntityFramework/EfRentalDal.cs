using Core.DataAccess.EntityFrameowrk;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentCarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {

                var result = from r in context.Rentals
                             join car in context.Cars
                             on r.CarId equals car.CarId
                             join customer in context.Customers
                             on r.CustomerId equals customer.Id
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             join user in context.Users
                             on customer.UserId equals user.Id
                             join company in context.Companies
                             on customer.CompanyId equals company.CompanyId
                             select new RentalDetailDto { Id = r.Id, CarBrandName = brand.BrandName, CarColorName = color.ColorName, 
                                                          CarDescription = car.CarDescription, CustomerCompanyName = company.CompanyName, 
                                                          CustomerName = user.FirstName + " " + user.LastName, RentDate = r.RentDate, ReturnDate = r.ReturnDate };
                return result.ToList();

            }
        }

        public IResult NotReturnedCarCheck(Rental rental)
        {
            List<Rental> _rentals = this.GetAll();

            Rental rentalToCheck = _rentals.SingleOrDefault(r => r.CarId == rental.CarId);

            if(rentalToCheck != null)
            {
                if(rentalToCheck.ReturnDate == null)
                {
                    return new ErrorResult();
                }
                return new SuccessResult();
            }
            return new SuccessResult();
        }
    }
}
