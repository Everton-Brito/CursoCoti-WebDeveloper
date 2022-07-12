

using ProjetoAula02.Controllers;

//localização da classe dentro do projeto
namespace ProjetoAula02
{
    //declaração da classe
    public class Program
    {
        //método para executar o projeto (inicialização)
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("(1) Cadastro de empresas");
                Console.WriteLine("(2) Cadastro de funcionários");

                Console.Write("\nInforme a opção desejada...: ");
                var opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        var empresaController = new EmpresaController();    
                        empresaController.CadastrarEmpresa();
                        break;

                    case 2:
                        var funcionarioController = new FuncionarioController();
                        funcionarioController.CadastrarFuncionario();   
                        break;

                    default:
                        Console.WriteLine("Opção Invalida");
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
