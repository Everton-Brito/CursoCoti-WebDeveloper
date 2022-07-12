using ProjetoAula02.Entities;
using ProjetoAula02.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula02.Controllers
{
    public class EmpresaController
    {
        public void CadastrarEmpresa()
        {
            try
            {
                Console.WriteLine("\n***CADASTRO DE EMPRESA***\n");

                var empresa = new Empresa();
                empresa.IdEmpresa = Guid.NewGuid();

                Console.Write("Nome Fantasia da empresa......: ");
                empresa.NomeFantasia = Console.ReadLine();

                Console.Write("Razao social da empresa ......: ");
                empresa.RazaoSocial = Console.ReadLine();

                Console.Write("CNPJ da empresa...............: ");
                empresa.Cnpj = Console.ReadLine();

                var empresaRepository = new EmpresaRepository();
                empresaRepository.Exportar(empresa);

                Console.WriteLine("EMPRESA CADASTRADA COM SUCESSO!");


            }
            catch (Exception e)
            {
                Console.WriteLine("\nFalha ao cadastrar empresa!");
                Console.WriteLine($"Erro: {e.Message}");
            }
        }
    }
}
