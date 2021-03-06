using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {

        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Remove(Customer customer);
        IDataResult<List<Customer>> GetById(int id);
        IDataResult<List<Customer>> GetAll();
        
    }
}
