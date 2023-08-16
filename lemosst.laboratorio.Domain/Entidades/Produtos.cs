namespace lemosst.laboratorio.Domain.Entidades
{
    public class Produtos
    {
        public int Id { get; set; }
        public string? NomeProduto { get; set; }
        public ICollection<ProdutoItens>? ProdutoItens { get; set; }
    }
}
