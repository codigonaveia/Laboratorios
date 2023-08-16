using lemosst.laboratorio.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lemosst.laboratorio.Data.DataConfiguration
{
    public class ProdutoItensConfig : IEntityTypeConfiguration<ProdutoItens>
    {
        public void Configure(EntityTypeBuilder<ProdutoItens> builder)
        {
            builder.ToTable(nameof(ProdutoItens));

            builder.HasKey(x => x.id);

            builder.Property(x=>x.DescricaoItens)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.HasOne(x => x.Produtos)
                .WithMany(i => i.ProdutoItens)
                .HasForeignKey(i => i.ProdutoId);

            builder.HasOne(x => x.SubItens)
               .WithMany(i => i.ProdutoItens)
               .HasForeignKey(i => i.SubItensId);
        }
    }
}
