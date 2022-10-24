using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SQCustomerManager : ISQCustomerService
    {
        ISQCustomerDal _sQCustomerDal;
        public SQCustomerManager(ISQCustomerDal sQCustomerDal)
        {
            _sQCustomerDal = sQCustomerDal;
        }
        public IResult Add(SQCustomer sQCustomer)
        {
            _sQCustomerDal.Add(sQCustomer);
            return new SuccessResult(Messages.AddedMessage);
        }

        public IDataResult<List<SQCustomer>> GetAll()
        {
            var res = _sQCustomerDal.GetAll();
            return new SuccessDataResult<List<SQCustomer>>(res,Messages.SuccessListedMessage);
        }
    }
}