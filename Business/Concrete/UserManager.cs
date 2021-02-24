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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            //İş Kodları
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            //İş Kodları
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<User> Get(Expression<Func<User, bool>> filter)
        {
            //İş Kodları
            return new SuccessDataResult<User>(_userDal.Get(filter));
        }

        public IDataResult<List<User>> GetAll()
        {
            //İş Kodları
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetUserById(int id)
        {
            //İş Kodları
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == id));
        }

        public IResult Update(User user)
        {
            //İş Kodları
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
