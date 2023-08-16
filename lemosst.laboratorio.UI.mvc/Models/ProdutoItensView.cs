namespace lemosst.laboratorio.UI.mvc.Models
{
    public class ProdutoItensView
    {
        public int id { get; set; }
        public int ProdutoId { get; set; }
        public string? DescricaoItens { get; set; }
        public int SubItensId { get; set; }
        public decimal PrecoUnitario { get; set; }
        public long Quantidade { get; set; }
    }
}
