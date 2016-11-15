﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SQL_New.Models
{
    public class Assignment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Assignment Name")]
        public string Name { get; set; }

        //[ForeignKey("Students")]
        //public Students Student { get; set; }

        // 1-m relation to courses

        [Required]
        [Display(Name = "Course Name")]
        public int CoursesID { get; set; }

        public int? CourseId { get; set; }
        
        public virtual Course Courses { get; set; }

        //public int? TeacherId { get; set; }

        //public virtual Teacher Teachers { get; set; }
    }
}