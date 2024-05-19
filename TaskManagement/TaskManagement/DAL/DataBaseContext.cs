using Microsoft.EntityFrameworkCore;
using TaskManagement.DAL.Entities;

namespace TaskManagement.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) //Por medio de este constructor me conecto a la base de datos
        { 

        }

        //Este metodo es propio de EFC me sirve para configurar unos indices de cada campo de una tabla de DB
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Tasks>().HasIndex(c => c.Id).IsUnique(); //Asi creo un indice del campo Name/Id  para la tabla Tasks
        }
        //Set de cada tabla en base de datos, por cada tabla se crea un DbSet, por cada entidad.

        #region DbSets 

        public DbSet<Tasks> Tasks { get; set; }
        #endregion

    }
}