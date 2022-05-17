using System;
using Microsoft.EntityFrameworkCore;

namespace ejercicios_ut3.Models
{
    public class EjercicioUT3Context : DbContext
    {
        public EjercicioUT3Context(DbContextOptions<EjercicioUT3Context> options)
            : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
 