using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerTaxNumber { get; set; }
        public string CustomerTaxAdmin { get; set; }
        public string CustomerAddress { get; set; }
    }
}