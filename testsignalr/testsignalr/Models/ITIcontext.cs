using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace testsignalr.Models
{
    public partial class ITIcontext : DbContext
    {
        public ITIcontext()
            : base("name=ITIcontext")
        {
        }

        public virtual DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
