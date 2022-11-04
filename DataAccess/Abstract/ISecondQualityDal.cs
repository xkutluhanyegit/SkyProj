using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concrete;
using Entities.Concrete.DTOs;

namespace DataAccess.Abstract
{
    public interface ISecondQualityDal:IEntityRepository<SecondQuality>
    {
        List<SQDetailDto> GetSQDetails();
        SecondQuality GetByModelAndCustomer(string model, int customerID);
        List<SecondQuality> GetByModel(string model);
        
    }
}