using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticaCode.AppWebMVC.Models;

namespace PracticaCode.AppWebMVC.Data
{
    public class PracticaCodeAppWebMVCContext : DbContext
    {
        public PracticaCodeAppWebMVCContext (DbContextOptions<PracticaCodeAppWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<PracticaCode.AppWebMVC.Models.Alumno> Alumno { get; set; } = default!;
        public DbSet<PracticaCode.AppWebMVC.Models.Empleado> Empleado { get; set; } = default!;
    }
}
