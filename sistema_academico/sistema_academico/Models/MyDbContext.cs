using Microsoft.EntityFrameworkCore;

namespace sistema_academico.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base  (options) { }
        public DbSet<Alumno> Alumno { get; set; }

        protected override void  OnModelCreating(ModelBuilder modelBuilder )
        {
          base.OnModelCreating (modelBuilder);
            modelBuilder.Entity<Alumno>().HasKey( e => e.idAlumno );
        }

    }
}
