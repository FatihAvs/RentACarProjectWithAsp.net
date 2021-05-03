using Core.Utilities.Results;
using Entity.Concrete;
using Entity.Dto;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        public IDataResult<List<CarImage>> GetAll();
        public IDataResult<CarImage> GetById(int id);
        public IResult Add(CarImage carImage, IFormFile file);
        public IResult Update(IFormFile file, CarImage carImage);
        public IResult Delete(CarImage carImage);

        public IDataResult<List<CarImage>> GetImagesByCarId(int carId);
    }
}
