using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAppAspnet.Models
{
    public class UserModel
    {
        public int UserId { get; set;}
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"(\S)+", ErrorMessage = "фигня кароч")]
        [Display(Name = "user name")]
        public string UserName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }
    }
}