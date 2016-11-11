using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SQL_New.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        // One course is required to have one teacher
        public Teacher Teachers { get; set; }

        // One course is required to have atleast one assignment
        public virtual ICollection<Assignment> Assignments { get; set; }

        // One course can have multiple students
        public virtual ICollection<Student> Students { get; set; }

    }
}