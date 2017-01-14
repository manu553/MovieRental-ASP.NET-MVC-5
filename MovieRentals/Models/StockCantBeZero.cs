using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
    public class StockCantBeZero : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if(movie.Stock == 0)
            {
                return new ValidationResult("Stock must be between 1 - 20");
            } else
            {
                return ValidationResult.Success;
            }
        }
    }
}