using Microsoft.EntityFrameworkCore;
using Practica01.Models;

namespace Practica01.Data
{
    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options)
            : base(options)
        {

        }

        public DbSet<Estudiantes> Estudiantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
