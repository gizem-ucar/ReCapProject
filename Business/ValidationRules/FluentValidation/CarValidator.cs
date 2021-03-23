using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.BrandName).NotEmpty();
            RuleFor(c=>c.BrandName).MinimumLength(2);
            RuleFor(c => c.BrandName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");


        }
        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
