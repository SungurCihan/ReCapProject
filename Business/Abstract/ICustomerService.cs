using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
        IDataResult<Customer> Get(Expression<Func<Customer, bool>> filter);
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetCustomerById(int id);
        IDataResult<List<Customer>> GetCustomersByUserId(int id);
        IDataResult<List<Customer>> GetCustomersByCompanyId(int id);
        IDataResult<List<CustomerDetailDto>> GetCustomerDetails();
    }
}
