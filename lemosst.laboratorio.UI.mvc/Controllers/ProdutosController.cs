using lemosst.laboratorio.Data.Migrations;
using lemosst.laboratorio.Domain.Entidades;
using lemosst.laboratorio.Domain.Interfaces;
using lemosst.laboratorio.Domain.UnitWork;
using lemosst.laboratorio.UI.mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ProdutoItens = lemosst.laboratorio.Domain.Entidades.ProdutoItens;

namespace lemosst.laboratorio.UI.mvc.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        //private readonly IProdutosServices _produtosServices;

        public ProdutosController(IUnitOfWork unitOfWork /*IProdutosServices produtosServices*/)
        {
            _unitOfWork = unitOfWork;
            //_produtosServices = produtosServices;

        }
        public async Task<IActionResult> Index(string term)
     {
            if(term != null)
            {
                //var resultados = await _produtosServices.GetProdutos(term);
                var resultados = await _unitOfWork.ProdutosServices.GetProdutos(term);
                return Json(resultados.Select(x=>x.NomeProduto));
            }

            return View();
           
        }
        [HttpPost]
        public async Task<IActionResult> BuscarProdutos(string nome)
        {
            if (nome != null)
            {
                var resultados = await _unitOfWork.ProdutosServices.GetProdutos(nome);
               
                return Json(resultados.Select(x=>x.NomeProduto));
            }

            return View();

        }

        [HttpPost]
        public async Task<JsonResult> AutoComplete(string term)
        {
            if (term != null)
            {
                //var resultados = await _produtosServices.GetProdutos(term);
                var itens = await _unitOfWork.SubItensService.GetSubItensAsync(term);
                //var rsultadosItens = resultados.Select(resultado => new
                //{
                //    Id = resultado.Id,
                //    Nome = resultado.Name
                //});
                var resultados = itens.Select(reusltado => new {
                    label = reusltado.Name,
                    value = reusltado.Id
                }).ToList();
                return Json(resultados);
            }
            return Json(null);
           

        }
        public async Task<IActionResult> CadastrarProduto(string term)
       {
            if (term != null)
            {
                //var resultados = await _produtosServices.GetProdutos(term);
                var itens = await _unitOfWork.SubItensService.GetSubItensAsync(term);
                //var rsultadosItens = resultados.Select(resultado => new
                //{
                //    Id = resultado.Id,
                //    Nome = resultado.Name
                //});
                var resultados =  itens.Select(reusltado => new{
                    label = reusltado.Name,
                    value = reusltado.Id
                }).ToList();
               
                return Json(resultados);
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CadastrarProduto(ProdutoViewModel model)
        {
            try
            {
                var produto = new Domain.Entidades.Produtos()
                {
                    NomeProduto = model.NomeProduto
                };
                await _unitOfWork.ProdutosServices.Cadastrar(produto);
                //await _produtosServices.Cadastrar(produto);
               model.Id = produto.Id;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return View(model);
        }

        public async Task<JsonResult> CadastrarProdutoItens(ProdutoItensView produtoItensView)
        {
            try
            {
                var produto = new ProdutoItens()
                {
                    DescricaoItens = produtoItensView.DescricaoItens,
                    ProdutoId = produtoItensView.ProdutoId,
                    SubItensId = produtoItensView.SubItensId,
                    PrecoUnitario = produtoItensView.PrecoUnitario,
                    Quantidade = produtoItensView.Quantidade
                };
                await _unitOfWork.ProdutoItensService.Cadastrar(produto);
            
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return Json(null);
        }


    }
}
