namespace COMP229_F2016_Assignment2_Part3.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CricketContext : DbContext
    {
        public CricketContext()
            : base("name=CricketContext")
        {
        }

        public virtual DbSet<Cricket> Crickets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cricket>()
                .Property(e => e.Teams)
                .IsUnicode(false);

            modelBuilder.Entity<Cricket>()
                .Property(e => e.Result)
                .IsUnicode(false);
        }
    }
}
