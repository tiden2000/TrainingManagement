using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TrainingManagement.Models {
    public class Trainer {
        public string TrainerId { get; set; }
        public string TrainerUsername { get; set; }
        public string TrainerPassword { get; set; }
        public string TrainerName { get; set; }
        public string TrainerWorkplace { get; set; }
        public string TrainerEmail { get; set; }
    }
    public class TrainerDbContext : DbContext {
        public DbSet<Trainer> Trainers { get; set; }
    }
}