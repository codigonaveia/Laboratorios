using lemosst.laboratorio.Domain.Entidades;
using lemosst.laboratorio.Domain.Interfaces.Base;

namespace lemosst.laboratorio.Domain.Interfaces
{
    public interface ISubItensServices:IBaseServices<SubItens>
    {
        Task<IEnumerable<SubItens>> GetSubItensAsync(string nome);
    }
}
