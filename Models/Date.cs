using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System;

namespace FormSubmission.Models
{
    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime)
            {
                DateTime compare = (DateTime)value;
                if (compare > DateTime.Now){
                    return ValidationResult.Success;
                }
                else{
                    return new ValidationResult("This date is not in future");
                }
                    
                
            }
            else{
                return new ValidationResult("Not a Valid Date");
            }
        }
    }
}