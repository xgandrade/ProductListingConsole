using ProductListingConsole.Domain;
using ProductListingConsole.Domain.Enum;
using ProductListingConsole.Interfaces;
using ProductListingConsole.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductListingConsole.Services
{
    public class ProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void AdicionarProduto(string descricao, double valorVenda, double valorCompra, TipoProduto tipo, DateTime dataCriacao)
        {
            if (valorVenda <= valorCompra)
            {
                Console.WriteLine($"O valor de venda do produto '{descricao}' deve ser maior que o valor de compra.");
                return;
            }
            if (dataCriacao < new DateTime(2024, 1, 1))
            {
                Console.WriteLine($"A data de criação do produto '{descricao}' deve ser posterior a 01/01/2024.");
                return;
            }
            if (descricao.Length < 5)
            {
                Console.WriteLine($"A descrição do produto '{descricao}' deve ter no mínimo 5 caracteres.");
                return;
            }
            if (valorCompra <= 0 || valorVenda <= 0)
            {
                Console.WriteLine($"Os valores de compra e venda do produto '{descricao}' devem ser maiores que zero.");
                return;
            }

            Produto produto = new()
            {
                Descricao = descricao,
                ValorVenda = valorVenda,
                ValorCompra = valorCompra,
                Tipo = tipo,
                DataCriacao = dataCriacao
            };

            try
            {
                _produtoRepository.Adicionar(produto);
                Console.WriteLine($"Produto '{descricao}' adicionado com sucesso!");
            }
            catch (Exception e)
            {
                throw new Exception($"Erro: {e.Message}");
            }
        }

        public void ExibirProdutosPorPeriodo(DateTime dataInicio, DateTime dataFim)
        {
            var produtos = _produtoRepository.FiltrarPorData(dataInicio, dataFim);
            foreach (var produto in produtos)
            {
                Console.WriteLine($"Descrição: {produto.Descricao}, Tipo: {produto.Tipo}, Data Criação: {produto.DataCriacao.ToShortDateString()}");
            }
        }

        public void ExibirProdutosPorMargemLucro(int quantidade)
        {
            var produtos = _produtoRepository.ObterComMaiorMargemLucro(quantidade);
            foreach (var produto in produtos) produto.ToString();
        }

        public void ListarProdutosMargemLucroSegundoSemestre(DateTime inicio, DateTime fim, int quantidade)
        {
            var produtos = _produtoRepository.ListarProdutosMargemLucroPorData(
                    inicio, 
                    fim, 
                    quantidade
                );

            foreach (var produto in produtos) 
                Console.WriteLine(produto.ToString()); 
        }
    }
}
