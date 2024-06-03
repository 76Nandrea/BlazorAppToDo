using System.ComponentModel.DataAnnotations;
using BlazorAppToDo.Validation;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace BlazorAppToDo.Model
{
    public class Todo
    {
        [Required]
        public int Id { get; set; }

        
        [Required]
        [MaxLength(50)]
        public string? Title { get; set; }

        public bool IsActive { get; set; } = true;


        [Required]
        [DataType(DataType.DateTime)]
        [TodoDateValidation]
        public DateTime Createdt { get; set; } = new DateTime(2024, 06, 01);


        [Required]
        [DataType(DataType.DateTime)]
        [Datecheck]
        public DateTime Deadline { get; set; } = new DateTime(2024, 06, 01);

        public bool ShowData { get; set; } = true;


    }
}
