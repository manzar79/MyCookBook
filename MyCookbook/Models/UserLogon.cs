using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
  using System.ComponentModel.DataAnnotations;

namespace MyCookbook.Models
{
    public class UserLogon
    {
        [Required]
        [Display(Name = "User Login")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
} 
    