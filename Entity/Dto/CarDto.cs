using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Dto
{
    public class CarDto:IDto
    {
        public int BrandId { get; set; }
        public string  CarName { get; set; }
        public string  BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
