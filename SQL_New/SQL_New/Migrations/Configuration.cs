namespace SQL_New.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SQL_New.Models.School>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SQL_New.Models.School context)
        {
            context.Students.AddOrUpdate(
              p => p.Name,
              new Student { Name = "Marcus Sturedahl" },
              new Student { Name = "Davis Davis" },
              new Student { Name = "Nima Nimaa" }
            );

            context.Teachers.AddOrUpdate(
              p => p.Name,
              new Teacher { Name = "Mike Ash" },
              new Teacher { Name = "Kent Gudmundsen"  },
              new Teacher { Name = "Anders Svensson" },
              new Teacher { Name = "Ulf Bengtsson" },
              new Teacher { Name = "Test Testsson" }
            );

            context.Courses.AddOrUpdate(
              p => p.Name,
              new Course { Name = "C# Fundamentals" },
              new Course { Name = "Databases" },
              new Course { Name = "WebSession" },
              new Course { Name = "WebDesign" },
              new Course { Name = "Math D" }
            );
        }
    }
}
