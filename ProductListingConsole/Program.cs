using ProductListingConsole.Domain.Enum;
using ProductListingConsole.Interfaces;
using ProductListingConsole.Repositories;
using ProductListingConsole.Services;

class Program
{
    static void Main(string[] args)
    {
        // Instanciando o repositório e serviço
        IProdutoRepository produtoRepository = new ProdutoRepository();
        ProdutoService produtoService = new (produtoRepository);

        // Adicionando produtos
        produtoService.AdicionarProduto("Produto1", 100, 70, TipoProduto.Final, new DateTime(2024, 2, 15));
        produtoService.AdicionarProduto("Produto2", 150, 90, TipoProduto.Intermediario, new DateTime(2024, 5, 20));
        produtoService.AdicionarProduto("Produto3", 200, 110, TipoProduto.Consumo, new DateTime(2024, 6, 10));
        produtoService.AdicionarProduto("Produto4", 250, 120, TipoProduto.MateriaPrima, new DateTime(2024, 4, 25));
        produtoService.AdicionarProduto("Produto5", 50, 30, TipoProduto.Final, new DateTime(2024, 7, 5));
        produtoService.AdicionarProduto("Produto6", 300, 30, TipoProduto.Final, new DateTime(2024, 2, 5));

        //  - Filtre os produtos criados no segundo trimestre de 2024.
        //  - Ordene os produtos por Tipo.
        //  - Exiba os 3 produtos com maior margem de lucro.
        produtoService.ListarProdutosMargemLucroSegundoSemestre(new DateTime(2024, 4, 1), new DateTime(2024, 6, 30), 3);
    }
}
