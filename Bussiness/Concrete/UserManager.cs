using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal ıUserDal)
        {
            _userDal = ıUserDal;
        }

        public IResult Add(User user)
        {
            if (user.Firstname.Length == 0)
            {
                return new ErrorResult(Messages.İncorrect);
            }
            else
            {
                _userDal.Add(user);
                return new SuccessResult(Messages.Correct);
            }

          
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UserListed);
        }

        public IDataResult<List<User>> GetById(int id)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u=>u.Id == id), Messages.UserListed);
        }

        public IResult Remove(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.Correct);
        }


        public IResult Update(User user)
        {    _userDal.Update(user);
            return new SuccessResult(Messages.Correct);
                 
        }
    }
}
