using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Brand:IEntity
    {
        public int id { get; set; }
        public string BrandName { get; set; }
    }
}