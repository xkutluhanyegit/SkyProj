using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSecondQualityDal : EfEntityRepositoryBase<SecondQuality, SkyDbContext>, ISecondQualityDal
    {
        public SecondQuality GetByModelAndCustomer(string model, int customerID)
        {
            using (SkyDbContext context = new SkyDbContext())
            {
                var var =  context.Set<SecondQuality>().Where(s=>s.SQModel == model && s.SQCustomerId == customerID).SingleOrDefault();
                return var;
            }
        }





        // public List<SQDetailDto> GetSQDetails()
        // {
        //     using (SkyDbContext context = new SkyDbContext())
        //     {
        //         var res = from b in context.brands
        //             join s in context.secondQualities
        //             on b.id equals s.SQBrandId
        //             join c in context.customers
        //             on s.SQCustomerId equals c.Id
        //             select new SQDetailDto {
        //                 Model = s.SQModel,
        //                 BrandName = b.BrandName,
        //                 QTY = s.SQQTY,
        //                 CustomerName = c.CustomerName

        //             };
        //         return res.ToList();
        //     }
        // }
        public List<SQDetailDto> GetSQDetails()
        {
            using (SkyDbContext context = new SkyDbContext())
            {
                var res = from s in context.secondQualities
                    join b in context.brands
                    on s.SQBrandId equals b.id
                    join c in context.customers
                    on s.SQCustomerId equals c.Id
                    select new SQDetailDto
                    {
                        Id = s.Id,
                        BrandName = b.BrandName,
                        CustomerName = c.CustomerName,
                        Model = s.SQModel,
                        QTY = s.SQQTY
                    };
                
                return res.ToList();
            }
        }
    }
}