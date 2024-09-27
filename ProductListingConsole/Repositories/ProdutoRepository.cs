using ProductListingConsole.Domain;
using ProductListingConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductListingConsole.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly List<Produto> _produtos = new List<Produto>();

        public void Adicionar(Produto produto)
        {
            _produtos.Add(produto);
        }

        public IEnumerable<Produto> ObterTodos()
        {
            return _produtos;
        }

        public IEnumerable<Produto> FiltrarPorData(DateTime inicio, DateTime fim)
        {
            return _produtos.Where(p => p.DataCriacao >= inicio && p.DataCriacao <= fim);
        }

        public IEnumerable<Produto> ObterComMaiorMargemLucro(int quantidade)
        {
            return _produtos.OrderByDescending(p => p.MargemLucro).Take(quantidade);
        }

        public IEnumerable<Produto> ListarProdutosMargemLucroPorData(DateTime inicio, DateTime fim, int quantidade)
        {
            return _produtos.Where(p => p.DataCriacao >= inicio && p.DataCriacao <= fim)
                .OrderBy(tp => tp.Tipo)
                .OrderByDescending(p => p.MargemLucro)
                .Take(quantidade);
        }
    }
}
