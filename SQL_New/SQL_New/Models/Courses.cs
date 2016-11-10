using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SQL_New.Models
{
    public class Courses
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        // One course can have multiple assignments
        public virtual ICollection<Assignments> Assignments { get; set; }
        public virtual ICollection<Students> Students { get; set; }

        [Required]

        public virtual ICollection<Teachers> Teachers { get; set; }

        //public int? StudentsID { get; set; }


        //public virtual Students Student { get; set; }

        //public int? AssignmentsID { get; set; }

        ////[ForeignKey("AssignmentsID")]
        //public virtual Assignments Assignment { get; set; }
        //[ForeignKey("ID")]
        //public Teachers Teachers { get; set; }
    }
}