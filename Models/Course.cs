using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TrainingManagement.Models {
    public class Course {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Topic { get; set; }
        public string Trainee { get; set; }
    }
    public class CourseDbContext : DbContext {
        public DbSet<Course> Courses { get; set; }
    }
}