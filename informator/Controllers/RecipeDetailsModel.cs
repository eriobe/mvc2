﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace informator.Controllers
{
    public class RecipeDetailsModel:IValidatableObject
    {
        [Required(ErrorMessage ="Du måste fylla i ett namn")]
        public string Name { get; set; }
        public string Summary { get; set; }
        public int CookingTimeInMinutes { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Name == Summary)
                yield return new ValidationResult("Description can't just contain the name");
            if (Summary.Contains("@"))
                yield return new ValidationResult("Description can't contain @ characters");
        }

        public class NoDrunknessAttribute : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                if (value == null)
                    return false;
                var ToCheck = value.ToString().ToLower();
                return !ToCheck.Contains("drunk") &&
                !ToCheck.Contains("hammered") &&
                !ToCheck.Contains("glad i hatten");
            }
            public override string FormatErrorMessage(string field)
            {
                return field + " should not talk about being drunk!";
            }
        }
        
    }
    
}
