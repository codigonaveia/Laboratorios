using lemosst.laboratorio.Data.Contexto;
using lemosst.laboratorio.Domain.Interfaces.Base;
using Microsoft.EntityFrameworkCore;

namespace lemosst.laboratorio.Data.Repositorios.Base
{
    public class BaseRepositoy<T> : IBaseServices<T>, IDisposable where T : class
    {
        private readonly DataContexto _dataContexto;
        public BaseRepositoy(DataContexto dataContexto)
        {
            _dataContexto = dataContexto;
        }
        public async Task Cadastrar(T obj)
        {
           await  _dataContexto.Set<T>().AddAsync(obj);
           await SaveChangesAsync();
        }


        public async Task Excluir(T obj)
        {
            _dataContexto.Set<T>().Remove(obj);
            await SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> listarTodos()
        {
            return await _dataContexto.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> obterPorId(T obj)
        {
            return await _dataContexto.Set<T>().FindAsync(obj)  ;
        }

        public async Task Update(T obj)
        {
            _dataContexto.Set<T>().Update(obj);
           await  SaveChangesAsync();
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private bool _disposed = false;
       

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                // TODO: dispose managed state (managed objects).
            }

            // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
            // TODO: set large fields to null.

            _disposed = true;
        }

        public async Task SaveChangesAsync()
        {
            await _dataContexto.SaveChangesAsync();
        }
    }
}
