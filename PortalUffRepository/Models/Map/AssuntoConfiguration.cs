using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PortalUffRepository.Models.Map
{
    public class AssuntoConfiguration : IEntityTypeConfiguration<Assunto>
    {
        public void Configure(EntityTypeBuilder<Assunto> builder)
        {
            builder.ToTable("Assunto");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .HasColumnName("Id")
                   .HasColumnType("int");

            builder.Property(x => x.Palavra)
                   .HasColumnName("Palavra")
                   .HasColumnType("varchar(100)");

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
