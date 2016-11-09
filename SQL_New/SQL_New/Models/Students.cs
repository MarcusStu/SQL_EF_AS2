using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SQL_New.Models
{
    [Table("Students")]
    public class Students
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        //public int CoursesID { get; set; }

        ////[ForeignKey("CoursesID")]
        public ICollection<Courses> Courses { get; set; }
    }
}