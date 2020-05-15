using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TrainingManagement.Models {
    public class Topic {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Trainer { get; set; }
    }
    public class TopicDbContext : DbContext {
        public DbSet<Topic> Topics { get; set; }
    }
}