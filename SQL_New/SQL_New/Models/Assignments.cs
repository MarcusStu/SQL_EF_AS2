using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SQL_New.Models
{
    public class Assignments
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        //[ForeignKey("Students")]
        //public Students Student { get; set; }

        // 1-m relation to courses

        [Required]
        [Display(Name = "Course Name")]
        public int CoursesID { get; set; }

        //[ForeignKey("CoursesID")]
        public virtual Courses Courses { get; set; }
    }
}