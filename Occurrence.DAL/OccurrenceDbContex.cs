using Microsoft.EntityFrameworkCore;
using Occurrence.DAL.Configurations;
using Occurrence.DAL.Models;

namespace Occurrence.DAL
{
    public class OccurrenceDbContex : DbContext
    {
        private readonly string _connectionString;

        public OccurrenceDbContex()
        {
        }
        public OccurrenceDbContex(DbContextOptions<OccurrenceDbContex> options) : base(options)
        { }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Incident> Incidents { get; set; }
        #region Required
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(AccountConfiguration.Configure);
            modelBuilder.Entity<Contact>(ContactConfiguration.Configure);
            modelBuilder.Entity<Incident>(IncidentConfiguration.Configure);
        }
        #endregion
    }
}
