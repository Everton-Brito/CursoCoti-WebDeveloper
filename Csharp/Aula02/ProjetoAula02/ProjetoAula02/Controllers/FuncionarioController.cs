using ProjetoAula02.Entities;
using ProjetoAula02.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula02.Controllers
{
    public class FuncionarioController
    {
        //método para capturar os dados de um funcionário
        //através do prompt de comandos do DOS
        public void CadastrarFuncionario()
        {
            try
            {
                Console.WriteLine("\n *** CADASTRO DE FUNCIONÁRIO *** \n");

                //variável de instância (objeto)
                var funcionario = new Funcionario();
                funcionario.IdFuncionario = Guid.NewGuid();

                Console.Write("Nome do funcionário.............: ");
                funcionario.Nome = Console.ReadLine();

                Console.Write("CPF do funcionário..............: ");
                funcionario.Cpf = Console.ReadLine();

                Console.Write("Matrícula do funcionário........: ");
                funcionario.Matricula = Console.ReadLine();

                Console.Write("Data de admissão do funcionário.: ");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

                //inicializando a propriedade empresa da classe funcionario
                funcionario.Empresa = new Empresa();
                funcionario.Empresa.IdEmpresa = Guid.NewGuid();

                Console.Write("Nome fantasia da empresa........: ");
                funcionario.Empresa.NomeFantasia = Console.ReadLine();

                Console.Write("Razão Social da empresa.........: ");
                funcionario.Empresa.RazaoSocial = Console.ReadLine();

                Console.Write("CNPJ da empresa.................: ");
                funcionario.Empresa.Cnpj = Console.ReadLine();

                //instanciando a classe FuncionarioRepository
                var funcionarioRepository = new FuncionarioRepository();
                funcionarioRepository.Exportar(funcionario);

                Console.WriteLine("\nFUNCIONÁRIO CADASTRADO COM SUCESSO!");

            }
            catch (Exception e)
            {
                Console.WriteLine("\nFalha ao cadastrar funcionário!");
                Console.WriteLine($"Erro: {e.Message}");
            }
        }
    }
}



