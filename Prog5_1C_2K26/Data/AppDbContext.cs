using Microsoft.EntityFrameworkCore;
using Prog5_1C_2K26.Models;

namespace Prog5_1C_2K26.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Sintoma> Sintomas { get; set; }
        public DbSet<TipoVacuna> TipoVacunas { get; set; }
        public DbSet<CentroVacunacion> CentrosVacunacion { get; set; }
    }
}