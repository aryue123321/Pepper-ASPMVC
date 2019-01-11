using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pepper.Models
{
    public class Min18YearsIfaMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MemberShipTypeId == MemberShipType.PAY_AS_YOU_GO)
                return ValidationResult.Success;
            if (customer.Birthday == null)
                return new ValidationResult("Birthday is Required");

            var age = DateTime.Today.Year - customer.Birthday.Value.Year;

            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Has to be 18 years old.");
        }
    }
}