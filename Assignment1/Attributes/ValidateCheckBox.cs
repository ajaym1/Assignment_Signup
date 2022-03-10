using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Attributes
{
    public class ValidateCheckBox: ValidationAttribute, IClientModelValidator
    {
        public override bool IsValid(object value)
        {
            return (bool)value;
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val-checkbox", ErrorMessage);
        }
    }
}
