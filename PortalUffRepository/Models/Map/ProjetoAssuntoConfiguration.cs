using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PortalUffRepository.Models.Map
{
    public class ProjetoAssuntoConfiguration : IEntityTypeConfiguration<ProjetoAssunto>
    {
        public void Configure(EntityTypeBuilder<ProjetoAssunto> builder)
        {
            builder.ToTable("ProjetoAssunto");

            builder.HasKey(x => x.Id);

            builder.HasOne(f => f.Projeto)
                   .WithMany(f => f.ProjetoAssuntos);

            builder.HasOne(f => f.Assunto)
                   .WithMany(f => f.ProjetoAssuntos);

            builder.Property(x => x.Id)
                   .HasColumnName("Id")
                   .HasColumnType("int");

            builder.Property(x => x.CriadoPor)
                   .HasColumnName("CriadoPor")
                   .HasColumnType("varchar(100)");

            builder.Property(x => x.CriadoEm)
                   .HasColumnName("CriadoEm")
                   .HasColumnType("datetime");

            builder.Property(x => x.ModifPor)
                   .HasColumnName("ModifPor")
                   .HasColumnType("varchar(100)");

            builder.Property(x => x.ModifEm)
                   .HasColumnName("ModifEm")
                   .HasColumnType("datetime");

        }
    }
}
