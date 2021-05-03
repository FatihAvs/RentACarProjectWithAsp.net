using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService


    {
        public IDataResult<List<Brand>> GetAll();
        public IResult Add(Brand brand);
        public IDataResult<List<Brand>> GetByBrandId(int id);
        public IResult Delete(Brand brand);
        public IResult Update(Brand brand);

    }
}
