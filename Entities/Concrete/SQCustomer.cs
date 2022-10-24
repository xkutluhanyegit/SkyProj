using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class SQCustomer:IEntity
    {
        public int id { get; set; }
        public string SQCustomerName { get; set; }
        public string SQCustomerAddress { get; set; }
        public string SQCustomerPhone { get; set; }
    }
}