using BusOverview.Model;
using BusOverview.Repository.Entities.Model;
using Microsoft.EntityFrameworkCore;

namespace BusOverview.Repository.Entities
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Linha> Linha { get; set; }
        public DbSet<LinhaDetalhe> LinhasDetalhe { get; set; }
        public DbSet<DetecaoTipo> DetecaoTipo { get; set; }
        public DbSet<OcorrenciaTipo> OcorrenciaTipo { get; set; }
        public DbSet<SeveridadeTipo> SeveridadeTipo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=busOwerview.db");
        }
    }
}
