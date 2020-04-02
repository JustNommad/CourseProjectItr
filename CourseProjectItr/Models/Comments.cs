using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectItr.Models
{
    public class Comments
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Comment { get; set; }
        public string ItemId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Number { get; set; }
    }
}
