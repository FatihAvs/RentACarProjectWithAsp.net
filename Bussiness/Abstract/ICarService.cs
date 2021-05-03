using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        public IDataResult<List<Car>> GetAll();
        public IResult Add(Car car);
        public IDataResult<List<Car>> GetCarsByColorId(int id);
        public IDataResult<List<Car>> GetCarsByBrandId(int id);
        public IResult Delete(Car car);
        public IResult Update(Car car);


    }
}
