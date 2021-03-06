using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Remove(User user);
        IDataResult<List<User>> GetById(int id);
        IDataResult<List<User>> GetAll();
       
    }
}
