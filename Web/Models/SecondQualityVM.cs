using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Web.Models
{
    public class SecondQualityVM:SecondQuality
    {
        
        public List<Brand> brands { get; set; }
        public List<Customer> customers { get; set; }
    }
}