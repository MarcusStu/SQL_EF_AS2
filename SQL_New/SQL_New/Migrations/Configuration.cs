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
              new Student { Name = "Marcus Sturedahl", CourseId = 1 },
              new Student { Name = "Davis Davis", CourseId = 2 },
              new Student { Name = "Nima Nimaa", CourseId = 3 }
            );

            context.Teachers.AddOrUpdate(
              p => p.Name,
              new Teacher { Name = "Mike Ash" },
              new Teacher { Name = "Kent Gudmundsen" },
              new Teacher { Name = "Anders Svensson" },
              new Teacher { Name = "Ulf Bengtsson" },
              new Teacher { Name = "Test Testsson" }
            );

            context.Courses.AddOrUpdate(
              p => p.Name,
              new Course { Name = "C# Fundamentals", TeacherId = 1 },
              new Course { Name = "Databases", TeacherId = 2 },
              new Course { Name = "WebSession", TeacherId = 3 },
              new Course { Name = "WebDesign", TeacherId = 4 },
              new Course { Name = "Math D", TeacherId = 5 }
            );
        }
    }
}
