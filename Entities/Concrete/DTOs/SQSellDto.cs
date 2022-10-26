using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class SQSellDto
    {
        public int customerId { get; set; }
        public string model { get; set; }
        public int qty { get; set; }
    }
}