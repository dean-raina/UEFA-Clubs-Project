using ClubPortal.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ClubPortal.DAL
{
    public class ClubContext : DbContext
    {

        public ClubContext() : base("ClubContext")
        {
        }

        public DbSet<Club> Clubs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}