using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
        IDataResult<Color> Get(Expression<Func<Color, bool>> filter);
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetColorById(int id);
    }
}
