using lemosst.laboratorio.Domain.Entidades;
using lemosst.laboratorio.Domain.Interfaces.Base;

namespace lemosst.laboratorio.Domain.Interfaces
{
    public interface IProdutosServices:IBaseServices<Produtos>
    {
        Task<IEnumerable<Produtos>> GetProdutos(string nome);

        
    }
}
