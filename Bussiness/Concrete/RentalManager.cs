using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentCarDal _rentCarDal;

        public RentalManager(IRentCarDal rentCarDal)
        {
            _rentCarDal = rentCarDal;
        }

        public IResult Add(Rental rental)
        {
            _rentCarDal.Add(rental);
            return new SuccessResult(Messages.Correct);

        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentCarDal.GetAll(), Messages.Correct);
        }

        public IDataResult<List<Rental>> GetById(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentCarDal.GetAll(r => r.Id==id), Messages.Correct);
        }

        public IResult Remove(Rental rental)
        {
            return new SuccessResult(Messages.RentalDeleted);
        }

       

        public IResult Update(Rental rental)
        {
            _rentCarDal.Update(rental);
                return new SuccessResult(Messages.RentalUpdated);
        }

       
    }
}
