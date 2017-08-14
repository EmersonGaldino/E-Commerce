using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Commerce.Domain.Repositories;

namespace E_Commerce.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutosRepositorie _repositorio;
        // GET: Produto
        public ActionResult Index()
        {
         _repositorio = new ProdutosRepositorie();
           var produtos = _repositorio.Produtos.Take(10);   
            return View(produtos);
        }
    }
}