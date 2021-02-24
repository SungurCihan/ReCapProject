using Core.DataAccess.EntityFrameowrk;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentCarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from customer in context.Customers
                             join user in context.Users
                             on customer.UserId equals user.Id
                             join company in context.Companies
                             on customer.CompanyId equals company.CompanyId
                             select new CustomerDetailDto { CustomerId = customer.Id, CompanyName = company.CompanyName, CustomerName = user.FirstName + " " + user.LastName };

                return result.ToList();
            }
        }
    }
}
