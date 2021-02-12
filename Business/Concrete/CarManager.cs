using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.DailyPrice < 0 || car.CarName.Length < 2)
            {
                return new ErrorResult(Messages.NotAdded);
            }

            _carDal.Add(car);
            return new SuccessResult(Messages.Added);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsBrandId(int brandId)
        {
            if (brandId <= 0)
            {
                return new ErrorDataResult<List<Car>>(Messages.NotListed);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId).ToList(), Messages.Listed);
        }

        public IDataResult<List<Car>> GetCarsColorId(int colorId)
        {
            if (colorId <= 0)
            {
                return new ErrorDataResult<List<Car>>(Messages.NotListed);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId).ToList(), Messages.Listed);
        }
    }
}
