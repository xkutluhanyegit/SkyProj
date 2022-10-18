using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;

namespace Business.Concrete
{
    public class SecondQualityManager : ISecondQualityService
    {
        ISecondQualityDal _secondQualityDal;
        
        public SecondQualityManager(ISecondQualityDal secondQualityDal)
        {
            _secondQualityDal = secondQualityDal;
        }

        public IResult Add(SecondQuality secondQuality)
        {
            _secondQualityDal.Add(secondQuality);
            return new SuccessResult(Messages.AddedMessage);
        }

        public IDataResult<List<SecondQuality>> GetAll()
        {
            var res = _secondQualityDal.GetAll();
            return new SuccessDataResult<List<SecondQuality>>(res,Messages.SuccessListedMessage);
        }

        public IDataResult<List<SQDetailDto>> GetSQDetails()
        {
            var res = _secondQualityDal.GetSQDetails();
            return new SuccessDataResult<List<SQDetailDto>>(res,Messages.SuccessListedMessage);
        }
    }
}