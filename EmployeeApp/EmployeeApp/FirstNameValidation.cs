using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeApp
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class FirstNameValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,ValidationContext validationContext)
        {
            if (value == null || value.ToString() == string.Empty) 
            {
                return new ValidationResult("Please Provide First Name");
            }

            return ValidationResult.Success;
        }
    }
}