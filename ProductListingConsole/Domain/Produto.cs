using ProductListingConsole.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductListingConsole.Domain
{
    public class Produto
    {
        public string Descricao { get; set; }
        public double ValorVenda { get; set; }
        public double ValorCompra { get; set; }
        public TipoProduto Tipo { get; set; }
        public DateTime DataCriacao { get; set; }

        public Produto() { }

        public Produto(string descricao, double valorVenda, double valorCompra, TipoProduto tipo, DateTime dataCriacao)
        {
            this.Descricao = descricao;
            this.ValorVenda = valorVenda;
            this.ValorCompra = valorCompra;
            this.Tipo = tipo;
            this.DataCriacao = dataCriacao;
        }

        public double MargemLucro => ValorVenda - ValorCompra;

        public override string ToString() => $"Descrição: {Descricao}, Margem de Lucro: {MargemLucro}, Tipo {Tipo}";
    }
}
