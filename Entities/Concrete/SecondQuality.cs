using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class SecondQuality:IEntity
    {
        public int Id { get; set; }
        public string SQModel { get; set; }
        public int SQBrandId { get; set; }
        public int SQQTY { get; set; }
        public int SQCustomerId { get; set; }
        public DateTime SQAddDate { get; set; } = DateTime.Now;
    }
}