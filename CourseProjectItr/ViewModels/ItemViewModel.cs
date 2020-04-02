using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace CourseProjectItr.ViewModels
{
    public class ItemViewModel
    {
        public string UserId { get; set; }
        public string CollectionId { get; set; }
        [Required(ErrorMessage = "DescriptionRequired")]
        public string Review { get; set; }
        [Required(ErrorMessage = "NameRequired")]
        public string Name { get; set; }
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }
        public virtual IFormFile ImageFile { get; set; }
        public string ImageStorageName { get; set; }
        public string OneText { get; set; }
        public string SecondText { get; set; }
        public string ThirdText { get; set; }
        public string CheckBox1 { get; set; }
        public string CheckBox2 { get; set; }
        public string CheckBox3 { get; set; }
        [RegularExpression(@"\d{1,2}\/\d{1,2}\/\d{2,4}$", ErrorMessage = "DateRegularExpression")]
        public string Time1 { get; set; }
        [RegularExpression(@"\d{1,2}\/\d{1,2}\/\d{2,4}$", ErrorMessage = "DateRegularExpression")]
        public string Time2 { get; set; }
        [RegularExpression(@"\d{1,2}\/\d{1,2}\/\d{2,4}$", ErrorMessage = "DateRegularExpression")]
        public string Time3 { get; set; }
        public string One { get; set; }
        public string Second { get; set; }
        public string Third { get; set; }
        [RegularExpression(@"\d*$", ErrorMessage = "NumberRegularExpression")]
        public string NumberOne { get; set; }
        [RegularExpression(@"\d*$", ErrorMessage = "NumberRegularExpression")]
        public string NumberSecond { get; set; }
        [RegularExpression(@"\d*$", ErrorMessage = "NumberRegularExpression")]
        public string NumberThird { get; set; }
    }
}
