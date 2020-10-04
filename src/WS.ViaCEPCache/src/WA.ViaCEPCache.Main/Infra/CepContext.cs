using Microsoft.EntityFrameworkCore;
using WA.ViaCEPCache.Main.Models;

namespace WA.ViaCEPCache.Main.Infra
{
    public class CepContext : DbContext
    {
        public DbSet<ViaCEPResponse> Ceps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\cep\cep.db;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}