using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PortalUffRepository.Models;
using PortalUffRepository.Models.Map;

namespace PortalUffRepository.Contexto
{
    public class PortalContexto : DbContext
    {
        protected readonly IConfiguration Configuration;

        public PortalContexto(DbContextOptions<PortalContexto> options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }

        public DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaConfiguration());
        }

    }
}
