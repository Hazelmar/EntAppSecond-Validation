using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EntAppSecond.Pages.Model
{
    public class Student
    {
        [Required]
        public string StudentID { get; set; } = " ";
        [Required(ErrorMessage = "Enter a valid Student number")]
       
        public string FirstName { get; set; } = " ";
        [Display(Name = "First Name")]
        [Required]
        public string LastName { get; set; } = " ";
        
       
        public Student()
        {

        }
    }
}
