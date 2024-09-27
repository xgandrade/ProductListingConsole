# Product Listing Console Application

## Descrição
Este é um aplicativo de console em C# que permite listar e gerenciar produtos. O projeto inclui funcionalidades para adicionar produtos com validações e realizar operações como filtrar produtos por data de criação, ordenar por tipo e exibir os produtos com a maior margem de lucro.

## Funcionalidades
- Adicionar produtos com validações rigorosas.
- Filtrar produtos criados no segundo trimestre de 2024.
- Ordenar produtos por tipo.
- Exibir os 3 produtos com a maior margem de lucro.

## Estrutura do Projeto
O projeto está organizado em várias pastas, conforme descrito abaixo:

/ProductListingConsole
│
├── /Domain                 # Contém as entidades de domínio
│   ├── Produto.cs          # Classe Produto (entidade de domínio)
|   |── / Enums             # Contém os Enums de domínio
│       ├── TipoProduto.cs      # Enum TipoProduto
│
├── /Interfaces                 # Contém as interfaces (contratos)
│   ├── IProdutoRepository.cs   # Interface do repositório de produtos
│
├── /Repositories             # Implementações dos repositórios
│   ├── ProdutoRepository.cs  # Implementação do repositório de produtos
│
├── /Services                 # Lógica de negócios e regras de validação
│   ├── ProdutoService.cs     # Serviço de produto (lógica de negócios)
│
└── Program.cs              # Ponto de entrada do programa


## Tecnologias Utilizadas
- C# (.NET Core)
- LINQ para manipulação de dados
- Estrutura de repositórios para gerenciamento de produtos
