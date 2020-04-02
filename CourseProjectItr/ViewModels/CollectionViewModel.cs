using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CourseProjectItr.ViewModels
{
    public class CollectionViewModel
    {
        public string UserId { get; set; }
        [Required(ErrorMessage = "DescriptionRequired")]
        public string Review { get; set; }
        [Required(ErrorMessage = "NameRequired")]
        [StringLength(16, MinimumLength = 3, ErrorMessage = "NameLength")]
        public string Name { get; set; }
        [StringLength(16, MinimumLength = 3, ErrorMessage = "NameLength")]
        public string Theme { get; set; }
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Poster")]
        public string ImageUrl { get; set; }
        [Display(Name = "ImageFile")]
        public virtual IFormFile ImageFile { get; set; }
        public string ImageStorageName { get; set; }
        [StringLength(16, MinimumLength = 3, ErrorMessage = "NameLength")]
        public string OneText { get; set; }
        [StringLength(16, MinimumLength = 3, ErrorMessage = "NameLength")]
        public string SecondText { get; set; }
        [StringLength(16, MinimumLength = 3, ErrorMessage = "NameLength")]
        public string ThirdText { get; set; }
        [StringLength(16, MinimumLength = 3, ErrorMessage = "NameLength")]
        public string CheckBox1 { get; set; }
        [StringLength(16, MinimumLength = 3, ErrorMessage = "NameLength")]
        public string CheckBox2 { get; set; }
        [StringLength(16, MinimumLength = 3, ErrorMessage = "NameLength")]
        public string CheckBox3 { get; set; }
        [StringLength(16, MinimumLength = 3, ErrorMessage = "NameLength")]
        public string Time1 { get; set; }
        [StringLength(16, MinimumLength = 3, ErrorMessage = "NameLength")]
        public string Time2 { get; set; }
        [StringLength(16, MinimumLength = 3, ErrorMessage = "NameLength")]
        public string Time3 { get; set; }
        [StringLength(16, MinimumLength = 3, ErrorMessage = "NameLength")]
        public string One { get; set; }
        [StringLength(16, MinimumLength = 3, ErrorMessage = "NameLength")]
        public string Second { get; set; }
        [StringLength(16, MinimumLength = 3, ErrorMessage = "NameLength")]
        public string Third { get; set; }
        [StringLength(16, MinimumLength = 3, ErrorMessage = "NameLength")]
        public string NumberOne { get; set; }
        [StringLength(16, MinimumLength = 3, ErrorMessage = "NameLength")]
        public string NumberSecond { get; set; }
        [StringLength(16, MinimumLength = 3, ErrorMessage = "NameLength")]
        public string NumberThird { get; set; }
    }
}
