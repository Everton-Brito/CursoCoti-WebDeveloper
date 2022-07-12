using Exercicio02.Entities;
using Exercicio02.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Controllers
{
    public class ProdutoController
    {
        //método para capturar os dados de um produto
        public void CadastrarProduto()
        {
            try
            {
                Console.WriteLine("\n****CADASTRO DE PRODUTOS****");

                //variável de instância (objeto)
                var produto = new Produto();
                produto.IdProduto = Guid.NewGuid();

                Console.Write("Nome do produto...............: ");
                produto.Nome = Console.ReadLine();

                Console.Write("Preço do produto..............: ");
                produto.Preco = decimal.Parse(Console.ReadLine());

                Console.Write("Quantidade do produto.........: ");
                produto.Quantidade = int.Parse(Console.ReadLine());

                var produtoRepository = new ProdutoRepository();
                produtoRepository.Exportar(produto);

                Console.WriteLine("\nPRODUTO CADASTRADO COM SUCESSO!");


            }
            catch (Exception e)
            {
                Console.WriteLine("\nFalha ao cadastrar produto!");
                Console.WriteLine($"Erro: {e.Message}");
            }
        }
    }
}
