using lemosst.laboratorio.Data.Contexto;
using lemosst.laboratorio.Domain.Interfaces;
using lemosst.laboratorio.Domain.UnitWork;

namespace lemosst.laboratorio.Data.Repositorios
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContexto _dataContexto;
        
        public IProdutoItensService ProdutoItensService { get; }
        public IProdutosServices ProdutosServices { get; }
        public ISubItensServices SubItensService { get; }

        public UnitOfWork(DataContexto dataContexto, 
            IProdutoItensService produtoItensService, 
            IProdutosServices produtosServices,
            ISubItensServices subItensServices)
        {
            _dataContexto = dataContexto ?? throw new ArgumentNullException(nameof(dataContexto)); ;
            ProdutoItensService = produtoItensService ?? throw new ArgumentNullException(nameof(produtosServices)); 
            ProdutosServices = produtosServices ?? throw new ArgumentNullException(nameof(produtoItensService));
            SubItensService = subItensServices ?? throw new ArgumentNullException(nameof(subItensServices));
        }
       
        public Task Save()
        {
            return _dataContexto.SaveChangesAsync();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dataContexto.Dispose();
            }
        }
    }
}
