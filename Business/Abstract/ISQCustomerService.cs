using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISQCustomerService
    {
        IResult Add(SQCustomer sQCustomer);
        IDataResult<List<SQCustomer>> GetAll();
    }
}