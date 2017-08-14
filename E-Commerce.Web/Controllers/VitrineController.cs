using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Commerce.Domain.Repositories;
using E_Commerce.Web.Models;


namespace E_Commerce.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorie _repositorio;

        public int ProdutosPorPagina = 3;
        // GET: Vitrine
        public ActionResult ListaProduto(int pagina = 1)
        {
            _repositorio = new ProdutosRepositorie();

            ProdutosViewModel model = new ProdutosViewModel
            {
                Produtos = _repositorio.Produtos
                    .OrderBy(p => p.Nome)
                    .Skip((pagina - 1) * ProdutosPorPagina)
                    .Take(ProdutosPorPagina),

                Paginacao = new Paginacao
                {
                    PaginaAtual = pagina,
                    ItensPorPagina = ProdutosPorPagina,
                    ItensTotal = _repositorio.Produtos.Count()
                }
            };
            
            return View(model);
        }
    }
}