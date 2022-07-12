//localização da classe dentro do projeto
using Exercicio02.Controllers;

namespace Exercicio02
{
    //definição da classe
    public class Program
    {
        //método para executar o projeto (inicialização)
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercicio Aula 02 c# Webdeveloper");

            try
            {
                Console.WriteLine("(1) Cadastro de produtos");
                Console.WriteLine("(2) Cadastro de Fornecedores");
                Console.WriteLine("\nInforme a opção desejada: ");
                var opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        var produtoController = new ProdutoController();
                        produtoController.CadastrarProduto();
                        break;

                    case 2:

                        var fornecedorController = new FornecedorController();
                        fornecedorController.CadastrarFornecedor();
                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"\nFalha: {e.Message}");
            }

            Console.ReadKey();
        }
    }
}

