using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SQL_New.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Teacher Name")]
        public string Name { get; set; }

        // One teacher can have multiple courses
        public virtual ICollection<Course> Courses { get; set; }

        // List of assignments is possible here, because one teacher assigned to a course can manually add assignments to a course..
        //public virtual ICollection<Assignment> Assignments { get; set; }
    }
}