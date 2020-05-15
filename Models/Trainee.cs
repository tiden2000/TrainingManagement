using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TrainingManagement.Models {
    public class Trainee {
        public string TraineeId { get; set; }
        public string TraineeUsername { get; set; }
        public string TraineePassword { get; set; }
        public string TraineeName { get; set; }
        public string TraineeLanguage { get; set; }
        public string TraineeDepartment { get; set; }
    }

    public class TraineeDbContext : DbContext {
        public DbSet<Trainee> Trainees { get; set; }

        public System.Data.Entity.DbSet<TrainingManagement.Models.CourseCategory> CourseCategories { get; set; }
    }
}