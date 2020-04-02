using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace CourseProjectItr.Models
{
    public class User : IdentityUser
    {
        public static object Identity { get; internal set; }
        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
