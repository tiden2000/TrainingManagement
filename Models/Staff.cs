using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TrainingManagement.Models {
    public partial class Staff {
        public string StaffId { get; set; }
        public string StaffUsername { get; set; }
        public string StaffPassword { get; set; }
    }

    public class StaffDbContext : DbContext {
        public DbSet<Staff> Staffs { get; set; }
    }
}