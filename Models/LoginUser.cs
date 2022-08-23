using System;
using System.ComponentModel.DataAnnotations;

namespace RecordStore.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage = "Please enter an email address.")]
        [EmailAddress]
        public string LoginEmail { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        public string LoginPassword { get; set; }
    }
}