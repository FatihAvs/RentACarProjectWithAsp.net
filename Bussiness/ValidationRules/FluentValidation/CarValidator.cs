﻿using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.ModelYear).NotEmpty();
        }
       
       
    }
}
