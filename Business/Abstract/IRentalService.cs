using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
        IDataResult<Rental> Get(Expression<Func<Rental, bool>> filter);
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IDataResult<Rental> GerRentalById(int id);
        IDataResult<List<Rental>> GetRentalsByCarId(int id);
        IDataResult<List<Rental>> GetRentalsByCustomerId(int id);
    }
}
