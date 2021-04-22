using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Update(Car car);

        IResult Delete(Car car);


        IDataResult<List<Car>> GetAll();

        IDataResult<List<Car>> GetByBrandId(int id);
        IDataResult<List<Car>> GetByColorId(int id);
        IDataResult<List<CarDetailsDto>> GetCarDetails();
        IDataResult<List<Car>> GetAllByBrandId(int brandId);
    }
}
