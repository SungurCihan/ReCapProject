using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        IDataResult<User> Get(Expression<Func<User, bool>> filter);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetUserById(int id);
    }
}
