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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            //İş Kodları
            if (brand.BrandName.Length >= 2)
            {
                _brandDal.Add(brand);
                return new SuccessResult(Messages.BrandAdded);
            }
            return new ErrorResult(Messages.BrandNameInvalid);
        }

        public IResult Delete(Brand brand)
        {
            //İş Kodları
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<Brand> Get(Expression<Func<Brand, bool>> filter)
        {
            //İş Kodları
            return new SuccessDataResult<Brand>(_brandDal.Get(filter));
        }

        public IDataResult<List<Brand>> GetAll()
        {
            //İş Kodları
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetBrandById(int id)
        {
            //İş Kodları
            return new SuccessDataResult<Brand>(_brandDal.Get(p => p.BrandId == id));
        }

        public IResult Update(Brand brand)
        {
            //İş Kodları
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
