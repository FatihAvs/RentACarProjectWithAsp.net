﻿using Core.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Car: IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string CarName { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Descriptions { get; set; }

    }
}