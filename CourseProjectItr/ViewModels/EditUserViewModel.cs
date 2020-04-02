
using System.ComponentModel.DataAnnotations;

namespace CourseProjectItr.ViewModels
{
    public class EditUserViewModel
    {
        public string Id { get; set; }
        [EmailAddress(ErrorMessage = "NameEmailAddress")]
        public string Email { get; set; }
        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Range(1, 110, ErrorMessage = "AgeRange")]
        public int Age { get; set; }
    }
}
