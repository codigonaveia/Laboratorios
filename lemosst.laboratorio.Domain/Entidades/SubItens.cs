namespace lemosst.laboratorio.Domain.Entidades
{
    public class SubItens
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<ProdutoItens>? ProdutoItens { get; set; }
    }
}
