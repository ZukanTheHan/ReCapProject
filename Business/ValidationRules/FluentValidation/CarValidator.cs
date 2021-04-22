using Entities.Concrete;
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
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.CarName).Must(StartWithUpperCase).WithMessage("Araba ismi büyük harfle başlamalıdır.");
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(100);
            RuleFor(c => c.Description).MinimumLength(10);
            RuleFor(c => c.ModelYear).NotEmpty();
            
        }

        private bool StartWithUpperCase(string arg)
        {
            return arg.StartsWith(arg.ToUpper());
        }
    }
}
