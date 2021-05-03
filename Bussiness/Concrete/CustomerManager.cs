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
    public class CustomerManager : ICustomerService
    {

        ICustomerDal _ıCustomerDal;

        public CustomerManager(ICustomerDal ıCustomerDal)
        {
            _ıCustomerDal = ıCustomerDal;
        }

        public IResult Add(Customer customer)
        {
            _ıCustomerDal.Add(customer);
            return new  SuccessResult(Messages.Correct);
        }

        public IDataResult<List<Customer>> GetAll()
        {
           return new SuccessDataResult<List<Customer>>(_ıCustomerDal.GetAll(),Messages.CustomerListed); 
            
        }

        public IDataResult<List<Customer>> GetById(int id)
        {
            return new SuccessDataResult<List<Customer>>(_ıCustomerDal.GetAll(c=>c.Id == id), Messages.Correct);
        }

        public IResult Remove(Customer customer)
        {
            _ıCustomerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

      
        public IResult Update(Customer customer)
        {
            _ıCustomerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }

       
        
    }
}
