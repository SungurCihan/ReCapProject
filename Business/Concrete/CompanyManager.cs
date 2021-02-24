using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public IResult Add(Company company)
        {
            //İş Kodları
            _companyDal.Add(company);
            return new SuccessResult(Messages.CompanyAdded);
        }

        public IResult Delete(Company company)
        {
            //İş Kodları
            _companyDal.Delete(company);
            return new SuccessResult(Messages.CompanyDeleted);
        }

        public IDataResult<Company> Get(Expression<Func<Company, bool>> filter)
        {
            //İş Kodları
            return new SuccessDataResult<Company>(_companyDal.Get(filter));
        }

        public IDataResult<List<Company>> GetAll()
        {
            //İş Kodları
            return new SuccessDataResult<List<Company>>(_companyDal.GetAll());
        }

        public IDataResult<Company> GetCompanyById(int id)
        {
            //İş Kodları
            return new SuccessDataResult<Company>(_companyDal.Get(p => p.CompanyId ==id));
        }

        public IResult Update(Company company)
        {
            //İş Kodları
            _companyDal.Update(company);
            return new SuccessResult(Messages.CompanyUpdated);
        }
    }
}
