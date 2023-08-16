namespace lemosst.laboratorio.Domain.Interfaces.Base
{
    public interface IBaseServices<T> where T : class
    {
        Task<T> obterPorId(T obj);
        Task Cadastrar(T obj);
        Task<IEnumerable<T>> listarTodos();
        Task Update(T obj);
        Task Excluir(T obj);
        Task SaveChangesAsync();
    }
}
