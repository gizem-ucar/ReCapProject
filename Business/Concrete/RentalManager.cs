using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
            
        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate == null && _rentalDal.GetCarDetails(r => r.CarId == rental.CarId).Count > 0)
            {
                return new ErrorResult(Messages.RentalCarInvalid);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalCar);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.CarDeleted);
        }
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentalId == rentalId));
        }

        public IDataResult<List<RentalDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetCarDetails());
        }

        public IResult Update(Rental rental)
        {
            if (rental.ReturnDate == null && _rentalDal.GetCarDetails(r => r.CarId == rental.CarId).Count > 0)
            {
                return new ErrorResult(Messages.CarUpdateInvalid);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.CarUpdate);
        }
        //public IDataResult<RentalDetailDto> GetRentalDetailsById(int id)
        //{
        //    return new SuccessDataResult<RentalDetailDto>(_rentalDal.GetRentalDetails(id));
        //}
    }
}
