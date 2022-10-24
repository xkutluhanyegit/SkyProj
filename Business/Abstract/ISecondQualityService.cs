using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Results;
using Entities.Concrete;
using Entities.Concrete.DTOs;

namespace Business.Abstract
{
    public interface ISecondQualityService
    {
        IResult Add(SecondQuality secondQuality);
        IResult Update(SecondQuality secondQuality);
        IDataResult<List<SecondQuality>> GetAll();
        IDataResult<List<SQDetailDto>> GetSQDetails();
        IDataResult<SecondQuality> GetByModelAndCustomer(string model, int customerID);

    }
}