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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            IResult _notReturnedCarCheckResult = _rentalDal.NotReturnedCarCheck(rental);

            if(_notReturnedCarCheckResult.Success == true)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
            }
            return new ErrorResult(Messages.RentalNotReturnError);
        }

        public IResult Delete(Rental rental)
        {
            //İş Kodları
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<Rental> GerRentalById(int id)
        {
            //İş Kodları
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
        }

        public IDataResult<Rental> Get(Expression<Func<Rental, bool>> filter)
        {
            //İş Kodları
            return new SuccessDataResult<Rental>(_rentalDal.Get(filter));
        }

        public IDataResult<List<Rental>> GetAll()
        {
            //İş Kodları
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            //İş Koldarı
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        public IDataResult<List<Rental>> GetRentalsByCarId(int id)
        {
            //İş Kodları
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CarId == id));
        }

        public IDataResult<List<Rental>> GetRentalsByCustomerId(int id)
        {
            //İş Kodları
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CustomerId == id));
        }

        public IResult Update(Rental rental)
        {
            //İş Kodları
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
