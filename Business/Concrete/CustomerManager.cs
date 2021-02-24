using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            //İş Kodlar
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            //İş Kodları
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<Customer> Get(Expression<Func<Customer, bool>> filter)
        {
            //İş Kodları
            return new SuccessDataResult<Customer>(_customerDal.Get(filter));
        }

        public IDataResult<List<Customer>> GetAll()
        {
            //İş Kodları
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<Customer> GetCustomerById(int id)
        {
            //İş Kodları
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.Id == id));
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomerDetails()
        {
            //İş Kodları
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomerDetails());
        }

        public IDataResult<List<Customer>> GetCustomersByCompanyId(int id)
        {
            //İş Kodları
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.CompanyId == id));
        }

        public IDataResult<List<Customer>> GetCustomersByUserId(int id)
        {
            //İş Kodları
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.UserId == id));
        }

        public IResult Update(Customer customer)
        {
            //İş Kodları
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
