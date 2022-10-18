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
        IDataResult<List<SecondQuality>> GetAll();
        IDataResult<List<SQDetailDto>> GetSQDetails();
    }
}