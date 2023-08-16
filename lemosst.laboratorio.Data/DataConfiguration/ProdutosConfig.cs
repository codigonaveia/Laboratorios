using lemosst.laboratorio.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace lemosst.laboratorio.Data.DataConfiguration
{
    public class ProdutosConfig : IEntityTypeConfiguration<Produtos>
    {
        public void Configure(EntityTypeBuilder<Produtos> builder)
        {
            builder.ToTable(nameof(Produtos));

            builder.HasKey(x => x.Id);
            builder.Property(x=>x.NomeProduto)
                .HasColumnType("varchar(50)");
        }
    }
}
