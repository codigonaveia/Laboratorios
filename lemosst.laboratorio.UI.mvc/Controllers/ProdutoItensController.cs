using lemosst.laboratorio.Domain.Entidades;
using lemosst.laboratorio.Domain.Interfaces;
using lemosst.laboratorio.UI.mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace lemosst.laboratorio.UI.mvc.Controllers
{
    public class ProdutoItensController : Controller
    {
        private readonly IProdutoItensService _produtoItensServices;

        public ProdutoItensController(IProdutoItensService produtoItensServices)
        {
            _produtoItensServices = produtoItensServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarItens(ProdutoItensView model)
        {
            try
            {
                var produto = new ProdutoItens()
                {
                    DescricaoItens = model.DescricaoItens
                };
                await _produtoItensServices.Cadastrar(produto);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return View();
        }
    }
}
