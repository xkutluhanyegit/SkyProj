using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SecondQualitySell
    {
        public int id { get; set; }
        public string model { get; set; }
        public int CustomerId { get; set; }
        public int QTY { get; set; }
        public int SQCustomerId { get; set; }
        public string Desc { get; set; }
    }
}