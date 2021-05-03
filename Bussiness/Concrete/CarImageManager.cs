using Business.Abstract;
using Business.Constants;
using Core.Utilities.Bussiness;
using Core.Utilities.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dto;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {

        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(CarImage carImage, IFormFile file)
        {
            carImage.ImagePath = FileHelper.Add(file);
            carImage.ImageDate = DateTime.Now;
            
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageAdded);

        }

        public IResult Delete(CarImage carImage)
        {
            FileHelper.Delete(carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarImagesDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.CarImagesListed);
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.Id == id));
        }



        public IDataResult<List<CarImage>> GetImagesByCarId(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(CheckIfCarImageIsNull(carId));
        }

        private List<CarImage> CheckIfCarImageIsNull(int carId)
        {
            var defaultPath = @"defaultImage.jpg";
            var result = _carImageDal.GetAll(c => c.CarId == carId);
            if (!result.Any())
            {
                return new List<CarImage> { new CarImage() { CarId = carId, ImageDate = DateTime.Now, ImagePath = defaultPath } };
            }
            return result;
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
                

                carImage.ImagePath = FileHelper.Update(carImage.ImagePath, file);
                carImage.ImageDate = DateTime.Now;
                _carImageDal.Update(carImage);
                return new SuccessResult();
            }

        private IResult CheckIfMaxImageLimit(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId);

            if (result.Count < 5)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }
    }

       
    }

