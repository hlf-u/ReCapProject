using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in context.Rentals
                             join c in context.Customers on r.CustomerId equals c.UserId
                             join u in context.Users on r.CustomerId equals u.Id
                             join d in context.Cars on r.CarId equals d.Id
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 CarId = d.Id,
                                 CustomerId = c.UserId,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 CompanyName = c.CompanyName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                

                             };
                return result.ToList();
            }
        }

    }
}
