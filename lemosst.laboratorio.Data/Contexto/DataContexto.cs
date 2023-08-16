using lemosst.laboratorio.Data.DataConfiguration;
using lemosst.laboratorio.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace lemosst.laboratorio.Data.Contexto
{
    public class DataContexto:DbContext
    {
        public DataContexto(DbContextOptions<DataContexto> options):base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produtos>(new ProdutosConfig().Configure);
            base.OnModelCreating(modelBuilder);
        }

        #region Tabelas
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<ProdutoItens> ProdutoItens { get; set; }
        public DbSet<SubItens> SubItens { get; set; }
        #endregion
    }
}
