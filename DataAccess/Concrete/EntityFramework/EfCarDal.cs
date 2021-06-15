using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, FinalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (FinalContext context=new FinalContext())
            {
                var result= from cr in context.Cars
                      join b in context.Brands
                      on cr.BrandId equals b.BrandId
                      join c in context.Colors
                      on cr.ColorId equals c.ColorId
                      select new CarDetailDto { ModelName = cr.ModelName, BrandName = b.BrandName, ColorName = c.ColorName, DailyPrice = cr.DailyPrice };

                return result.ToList();


            }
        }
    }
}
