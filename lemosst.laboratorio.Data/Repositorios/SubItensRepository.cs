using lemosst.laboratorio.Data.Contexto;
using lemosst.laboratorio.Data.Repositorios.Base;
using lemosst.laboratorio.Domain.Entidades;
using lemosst.laboratorio.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lemosst.laboratorio.Data.Repositorios
{
    public class SubItensRepository : BaseRepositoy<SubItens>, ISubItensServices
    {
        private readonly DataContexto _dataContexto;

        public SubItensRepository(DataContexto dataContexto) : base(dataContexto)
        {
            _dataContexto = dataContexto;
        }

        public async Task<IEnumerable<SubItens>> GetSubItensAsync(string nome)
        {
            var resultados = await _dataContexto.SubItens.Where(x => x.Name.Contains(nome))
                //.Select(s => new SubItens
                //{
                //    Id = s.Id,
                //    Name = s.Name,
                //})
               
                .ToListAsync(); 
            return resultados;  
        }
    }
}
