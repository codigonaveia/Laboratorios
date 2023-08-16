using lemosst.laboratorio.Domain.Interfaces;

namespace lemosst.laboratorio.Domain.UnitWork
{
    public interface IUnitOfWork:IDisposable
    {
        //IBaseServices<Produtos> Produtos { get; }
        //IBaseServices<ProdutoItens> ProdutoItens { get; }

        IProdutosServices ProdutosServices { get; }
        IProdutoItensService ProdutoItensService { get; }
        ISubItensServices SubItensService { get; }
        Task Save();
        void Dispose();

    }
}
