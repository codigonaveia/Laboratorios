using lemosst.laboratorio.Data.Contexto;
using lemosst.laboratorio.Data.Repositorios.Base;
using lemosst.laboratorio.Domain.Entidades;
using lemosst.laboratorio.Domain.Interfaces;

namespace lemosst.laboratorio.Data.Repositorios
{
    public class ProdutoItensRepository : BaseRepositoy<ProdutoItens>, IProdutoItensService
    {
        public ProdutoItensRepository(DataContexto dataContexto) : base(dataContexto)
        {
        }
    }
}
