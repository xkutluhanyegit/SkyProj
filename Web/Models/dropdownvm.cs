using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Web.Models
{
    public class dropdownvm
    {
        public Customer customers { get; set; }
        public SecondQuality secondqualities { get; set; }
    }
}