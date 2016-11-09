namespace SQL_New.Migrations
{
    using SQL_New.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<School>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(School context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //context.Courses.AddOrUpdate(
            //  p => p.Name,
            //  new Courses { Name = "C# Fundamentals" },
            //  new Courses { Name = "Databases" },
            //  new Courses { Name = "Javascript" }
            //);

            context.Students.AddOrUpdate(
              p => p.Name,
              new Students { Name = "Andrew Peters" },
              new Students { Name = "Brice Lambson" },
              new Students { Name = "Rowan Miller" }
            );

            context.Teachers.AddOrUpdate(
              p => p.Name,
              new Teachers { Name = "Mike Ash" },
              new Teachers { Name = "Kent Gudmundsen" },
              new Teachers { Name = "Anders Svensson" }
            );


            //context.Assignments.AddOrUpdate(
            //  p => p.Name,
            //  new Assignments { Name = "Console commands", CoursesID = 1 },
            //  new Assignments { Name = "First db assignment", CoursesID = 2 },
            //  new Assignments { Name = "Sokoban Game", CoursesID = 3 }
            //);
        }
    }
}
