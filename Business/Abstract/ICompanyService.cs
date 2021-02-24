using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICompanyService
    {
        IResult Add(Company company);
        IResult Delete(Company company);
        IResult Update(Company company);
        IDataResult<Company> Get(Expression<Func<Company, bool>> filter);
        IDataResult<List<Company>> GetAll();
        IDataResult<Company> GetCompanyById(int id);
    }
}
