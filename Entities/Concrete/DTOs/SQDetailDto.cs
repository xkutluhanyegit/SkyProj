using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete.DTOs
{
    public class SQDetailDto:IDto
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string BrandName { get; set; }
        public int QTY { get; set; }
        public string CustomerName { get; set; }
    }
}