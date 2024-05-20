using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TaskManagement.DAL.Entities;

namespace TaskManagement.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) //Through this constructor I connect to the database
        { 

        }

        //This method is specific to EFC and it helps me configure indexes for each field in a DB table.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Tasks>().HasIndex(c => c.Id).IsUnique(); // This is how I create an index of the Name/ Id field for the Tasks table
        }
        //Set of each table in the database, for each table a DbSet is created for each entity.

        #region DbSets 

        public DbSet<Tasks> Tasks { get; set; }
        #endregion

    }
}