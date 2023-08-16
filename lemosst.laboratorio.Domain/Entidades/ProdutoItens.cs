namespace lemosst.laboratorio.Domain.Entidades
{
    public class ProdutoItens
    {
        public int id { get; set; }
        public string? DescricaoItens { get; set; }
        public int ProdutoId { get;set; }
        public Produtos? Produtos { get; set; }
        public int SubItensId { get; set; }
        public SubItens? SubItens { get; set; }

        public decimal PrecoUnitario { get; set; }  
        public long Quantidade { get; set; }
       
    }
}
