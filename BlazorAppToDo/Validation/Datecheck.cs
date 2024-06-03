using BlazorAppToDo.Model;
using System.ComponentModel.DataAnnotations;

namespace BlazorAppToDo.Validation
{
    public class DatecheckAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var todo = (Todo)validationContext.ObjectInstance;
            if (todo.Deadline <= todo.Createdt)
            {
                return new ValidationResult("The deadline should be finished after created date.");
            }
            return ValidationResult.Success;
        }
    }
}
