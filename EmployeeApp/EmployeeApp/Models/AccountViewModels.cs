using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeApp.Models
{
    public class RegisterViewModel
    {
        //[Required]
        [Display(Name = "First name")]
        [StringLength(10)]
        [FirstNameValidation]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Address Line1")]
        public string AddrLine1 { get; set; }
    }
}
