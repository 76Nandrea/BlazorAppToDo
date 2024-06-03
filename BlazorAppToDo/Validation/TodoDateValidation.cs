using System.ComponentModel.DataAnnotations;

namespace BlazorAppToDo.Validation
{
    public class TodoDateValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is DateTime date)
            {
                if (date < DateTime.Today)
                {
                    return new ValidationResult("The past create date not possible!");

                }
            }

            return ValidationResult.Success!;
        }
    }
}

