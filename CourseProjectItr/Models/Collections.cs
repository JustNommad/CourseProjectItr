using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace CourseProjectItr.Models
{
    public class Collections
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Review { get; set; }
        public string Name { get; set; }
        public string Theme { get; set; }
        public string ImageUrl { get; set; }
        public string ImageStorageName { get; set; }
        public string OneText { get; set; }
        public string SecondText { get; set; }
        public string ThirdText { get; set; }
        public string CheckBox1 { get; set; }
        public string CheckBox2 { get; set; }
        public string CheckBox3 { get; set; }
        public string Time1 { get; set; }
        public string Time2 { get; set; }
        public string Time3 { get; set; }
        public string One { get; set; }
        public string Second { get; set; }
        public string Third { get; set; }
        public string NumberOne { get; set; }
        public string NumberSecond { get; set; }
        public string NumberThird { get; set; }
    }
}
