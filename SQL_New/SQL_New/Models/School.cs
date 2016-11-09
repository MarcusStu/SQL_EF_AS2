namespace SQL_New.Models
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class School : DbContext
    {
        // Your context has been configured to use a 'School' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MVC_SQL_EF.School' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'School' 
        // connection string in the application configuration file.
        public School()
            : base("name=School")
        {
        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Assignments> Assignments { get; set; }

        //public virtual DbSet<School> SchoolEntities { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        //School Schoolcontext = new School();

    }
}