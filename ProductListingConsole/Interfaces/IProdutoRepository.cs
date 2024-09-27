using ProductListingConsole.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductListingConsole.Interfaces
{
    public interface IProdutoRepository
    {
        void Adicionar(Produto produto);
        IEnumerable<Produto> ObterTodos();
        IEnumerable<Produto> FiltrarPorData(DateTime inicio, DateTime fim);
        IEnumerable<Produto> ObterComMaiorMargemLucro(int quantidade);
        IEnumerable<Produto> ListarProdutosMargemLucroPorData(DateTime inicio, DateTime fim, int quantidade);
    }
}
