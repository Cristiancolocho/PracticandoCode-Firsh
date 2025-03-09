using Microsoft.EntityFrameworkCore;
namespace PracticaCode.AppWebMVC.Models
{
    public class AlumnosDbContext: DbContext
    {
        public AlumnosDbContext(DbContextOptions<AlumnosDbContext> options) : base(options) { }
        public DbSet<Alumno> Alumnos { get; set; }
    }
}
