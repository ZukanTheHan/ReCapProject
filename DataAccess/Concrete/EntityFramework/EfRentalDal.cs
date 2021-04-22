using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailsDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from rea in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars
                             on rea.CarId equals c.Id
                             join cs in context.Customers
                             on rea.CustomerId equals cs.UserId
                             join usr in context.Users
                             on cs.UserId equals usr.Id
                             select new RentalDetailsDto
                             {
                                RentalId = rea.Id,
                                CustomerName=cs.CompanyName,
                                UserName = usr.FirstName + " " + usr.LastName,
                                Model  = c.ModelYear,
                                RentDate = rea.RentDate,
                                ReturnDate = rea.ReturnDate,
                                
 
                                
                             };
                return result.ToList();
            }
        }
    }
}
