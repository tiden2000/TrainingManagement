using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TrainingManagement.Models {
    public class CourseCategory {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class CourseCategoryDbContext : DbContext {
        public DbSet<CourseCategory> CourseCategories { get; set; }
    }
}