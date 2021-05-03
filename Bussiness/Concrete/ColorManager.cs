using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService

    {
        public IColorDal _ıColorDal = new EfColorDal();
        IColorDal _ııColorDal;

        public ColorManager(IColorDal ıColorDal)
        {
            _ııColorDal = ıColorDal;
        }

        public IResult Add(Color color)
        {
            _ıColorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            _ıColorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_ıColorDal.GetAll(), Messages.ColorListed);
        }

        

        public IResult Update(Color color)
        {

            _ıColorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
