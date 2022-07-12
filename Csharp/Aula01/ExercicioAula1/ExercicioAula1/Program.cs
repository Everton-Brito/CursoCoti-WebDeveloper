//localização da classe no projeto
using ExercicioAula1.Entities;
using ExercicioAula1.Repository;

namespace ExercicioAula1
{
    //declaração da classe -> public visibilidade da classe (acesso total)
    public class Program
    {
        //método que tem a função de executar o projeto
        public static void Main(string[] args)
        {
            Console.WriteLine("\n***CADASTRO DE FUNCIONARIOS***\n");

            //variável de instância / objeto
            var funcionario = new Funcionario();
            funcionario.IdFuncionario = Guid.NewGuid();

            Console.Write("INFORME O NOME DO FUNCIONARIO.......: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("INFORME O CPF DO FUNCIONARIO........: ");
            funcionario.Cpf = Console.ReadLine();

            Console.Write("INFORME A MATRICULA DO FUNCIONARIO..: ");
            funcionario.Matricula = Console.ReadLine();

            funcionario.DataAdmissao = DateTime.Now;

            //imprimindo os dados
            Console.WriteLine("\nDADOS DO FUNCIONARIO:");
            Console.WriteLine($"\tID DO FUNCIONARIO..............: {funcionario.IdFuncionario}");
            Console.WriteLine($"\tNOME DO FUNCIONARIO............: {funcionario.Nome}");
            Console.WriteLine($"\tCPF DO FUNCIONARIO.............: {funcionario.Cpf}");
            Console.WriteLine($"\tMATRICULA DO FUNCIONARIO.......: {funcionario.Matricula}");
            Console.WriteLine($"\tDATA DE ADMISSAO...............: {funcionario.DataAdmissao}");

            //variável de instância / objeto (repository)
            var funcionarioRepository = new FuncionarioRepository();
            //cadastrando funcionario
            funcionarioRepository.CadastrarFuncionario(funcionario);

            Console.WriteLine("\nARQUIVO GRAVADO COM SUCESSO!");

            Console.ReadKey();



        }
    }

}
