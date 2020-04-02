using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CourseProjectItr.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "EmailRequired")]
        [EmailAddress(ErrorMessage = "InEmailAddress")]
        [Remote(action: "CheckEmail", controller: "Account", ErrorMessage = "UsEmail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "NickRequired")]
        public string NickName { get; set; }
        [Required(ErrorMessage = "FirstRequired")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastRequired")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "AgeRequired")]
        [Range(1, 110, ErrorMessage = "AgeRange")]
        public int Age { get; set; }
        [Required(ErrorMessage = "PasswordRequired")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "PasswordCompare")]
        public string ConfirmPassword { get; set; }
    }
}
