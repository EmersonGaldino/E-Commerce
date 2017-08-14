using E_Commerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Repositories
{
    public class ProdutosRepositorie
    {
        private readonly EfDBContext _context = new EfDBContext();
        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }
    }
}
