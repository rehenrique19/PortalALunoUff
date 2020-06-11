using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PortalUffRepository.Models.Map
{
    public class ProjetoConfiguration : IEntityTypeConfiguration<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> builder)
        {
            builder.ToTable("Projeto");

            builder.HasKey(x => x.Id);

            builder
                .HasOne(f => f.Coordenador)
                .WithMany(i => i.Projetos);

            builder
                .HasOne(f => f.Equipe)
                .WithMany(i => i.Projetos);

            builder
                .HasOne(f => f.Status)
                .WithMany(i => i.Projetos);

            builder.Property(x => x.Id)
                   .HasColumnName("Id")
                   .HasColumnType("int");

            builder.Property(x => x.Titulo)
                   .HasColumnName("Titulo")
                   .HasColumnType("varchar(100)");

            builder.Property(x => x.Data)
                   .HasColumnName("Nome")
                   .HasColumnType("datetime");

            builder.Property(x => x.Descricao)
                   .HasColumnName("Descricao")
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
