using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name Required")]
        [MaxLength(50, ErrorMessage ="Name length can't exceed 50 ")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Email Required")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",ErrorMessage ="Invalid Email format")]   
        [Display(Name ="Office Email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Department Required")]
        public Dept? Department { get; set; }
    }
}
