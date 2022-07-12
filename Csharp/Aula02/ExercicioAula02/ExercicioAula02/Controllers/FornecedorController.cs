using Exercicio02.Entities;
using Exercicio02.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Controllers
{
    public class FornecedorController
    {
        //método para capturar os dados de um fornecedor
        public void CadastrarFornecedor()
        {
            try
            {
                //variável de instância (objeto)
                var fornecedor = new Fornecedor();
                fornecedor.IdFornecedor = Guid.NewGuid();

                Console.Write("Nome do Fornecedor....: ");
                fornecedor.Nome = Console.ReadLine();

                Console.Write("CNPJ..................: ");
                fornecedor.Cnpj = Console.ReadLine();

                var fornecedorRepository = new FornecedorRepository();
                fornecedorRepository.Exportar(fornecedor);

                Console.WriteLine("\nFORNECEDOR CADASTRADO COM SUCESSO!");

            }
            catch (Exception e)
            {
                Console.WriteLine("\nFALHA NO CADASTRO!");
                Console.WriteLine($"\nErro: {e.Message}");   
            }
        }
    }
}
