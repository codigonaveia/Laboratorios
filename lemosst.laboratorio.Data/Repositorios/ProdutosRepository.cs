using lemosst.laboratorio.Data.Contexto;
using lemosst.laboratorio.Data.Repositorios.Base;
using lemosst.laboratorio.Domain.Entidades;
using lemosst.laboratorio.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lemosst.laboratorio.Data.Repositorios
{
    public class ProdutosRepository : BaseRepositoy<Produtos>, IProdutosServices
    {
        private readonly DataContexto _dataContexto;

        public ProdutosRepository(DataContexto dataContexto) : base(dataContexto)
        {
            _dataContexto = dataContexto;
        }

      

        public async Task<IEnumerable<Produtos>> GetProdutos(string nome)
        {
            //var resultados = await Task.Run(()=>
            //    _dataContexto.Produtos.Where(x => x.NomeProduto.Contains(nome, StringComparison.OrdinalIgnoreCase))
            //    .Select(i=> i.NomeProduto)
            //    .ToListAsync());
            var resultado = await _dataContexto.Set<Produtos>().Where(x => x.NomeProduto.Contains(nome))
                .ToListAsync();
            return resultado;
        }
    }
}
