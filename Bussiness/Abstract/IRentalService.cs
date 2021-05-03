using Core.Utilities.Results;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Remove(Rental rental);
        IDataResult<List<Rental>> GetById(int id);
        IDataResult<List<Rental>> GetAll();
       

    
}
}
