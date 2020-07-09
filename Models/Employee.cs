using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDMVCDockerdotnetcore.Models
{
    public class Employee
    {
      [Key]
       public int empId { get; set; }
       [Required(ErrorMessage ="Please enter the employee Name")]
       [Display(Name ="Employee Name")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage ="Please enter the Age must be 18 to 56")]
        [Display(Name ="Age")]
        [Range(18,56)]
        public int Age { get; set; }
        [Required(ErrorMessage = "Please enter the Email Address")]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Please enter the Salary")]
        [Display(Name = "Salary")]
        
        public int Salary { get; set; }
       
    }
}
