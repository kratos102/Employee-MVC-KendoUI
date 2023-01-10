using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Models
{
    public class EmployeeViewModel
    {
        [Key, Required]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Employee Name required")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Password required")]
        public string EmployeePassword { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("EmployeePassword")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Employee Email required")]
        [DataType(DataType.EmailAddress)]
        public string EmployeeEmail { get; set; }

        [Required(ErrorMessage = "Employee Phone number required")]
        [MaxLength(11, ErrorMessage = "Phone number must be 11 characters")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        public string EmployeePhoneNumber { get; set; }
    }
}