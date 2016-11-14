using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SQL_New.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Student Name")]
        public string Name { get; set; }

        // Assign student to course

        [Display(Name = "Course Name")]
        public int? CourseId { get; set; }

        //public virtual Course courses { get; set; }

        // One student can have multiple courses

        public virtual ICollection<Course> Courses { get; set; }
    }
}