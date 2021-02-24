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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            //İş Kodları
            if (color.ColorName.Length >=2)
            {
                _colorDal.Add(color);
                return new SuccessResult(Messages.ColorAdded);
            }
            return new ErrorResult(Messages.ColorNameInvalid);
        }

        public IResult Delete(Color color)
        {
            //İş Kodları
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<Color> Get(Expression<Func<Color, bool>> filter)
        {
            //İş Kodları
            return new SuccessDataResult<Color>(_colorDal.Get(filter));
        }


        public IDataResult<List<Color>> GetAll()
        {
            //İş Kodları
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> GetColorById(int id)
        {
            //İş Kodları
            return new SuccessDataResult<Color>(_colorDal.Get(p => p.ColorId == id));
        }

        public IResult Update(Color color)
        {
            //İş Kodları
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
