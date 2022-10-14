using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete.DTOs
{
    public class OrderDetailDto:IDto
    {
        public string BrandName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string OrderModel { get; set; }
    }
}