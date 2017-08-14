using System;
using System.Runtime.InteropServices;
using System.Web.Mvc;
using E_Commerce.Web.HTMLHelpers;
using E_Commerce.Web.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_Commerce.UnitTest
{
    [TestClass]
    public class UnitTestECommerce
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void GerarPaginacao()
        {
            HtmlHelper html = null;
            Paginacao paginacao = new Paginacao
            {
                PaginaAtual = 2,
                ItensPorPagina = 10,
                ItensTotal = 28,
            };
            Func<int, string> paginaUrl = i => "pagina" + i;

            MvcHtmlString resultado = html.PageLinks(paginacao, paginaUrl);

            Assert.AreEqual(
                @"<a class=""btn btn-default"" href=""pagina1"">1</a>"
                + @"<a class=""btn btn-default btn-primary selected"" href=""pagina2"">2</a>"
                + @"<a class=""btn btn-default"" href=""pagina3"">3 </a>", resultado.ToString()
                );
        }
    }
}
