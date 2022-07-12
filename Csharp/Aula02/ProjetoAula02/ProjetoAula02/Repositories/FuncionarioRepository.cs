using ProjetoAula02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula02.Repositories
{
    public class FuncionarioRepository
    {
        //método para exportar dados do funcionário para arquivo
        public void Exportar(Funcionario funcionario)
        {
            //criando arquivo
            using (var streamWriter = new StreamWriter($"c:\\temp\\funcionario_{funcionario.IdFuncionario}.txt"))
            {
                //escrevendo os dados do funcionario no arquivo.
                streamWriter.WriteLine($"ID.................: {funcionario.IdFuncionario}");
                streamWriter.WriteLine($"NOME DO FUNCIONÁRIO: {funcionario.Nome}");
                streamWriter.WriteLine($"CPF................: {funcionario.Cpf}");
                streamWriter.WriteLine($"MATRICULA..........: {funcionario.Matricula}");
                streamWriter.WriteLine($"DATA DE ADMISSAO...: {funcionario.DataAdmissao}");
                streamWriter.WriteLine($"ID DA EMPRESA......: {funcionario.Empresa.IdEmpresa}");
                streamWriter.WriteLine($"NOME FANTASIA......: {funcionario.Empresa.NomeFantasia}");
                streamWriter.WriteLine($"RAZAO SOCIAL.......: {funcionario.Empresa.RazaoSocial}");
                streamWriter.WriteLine($"CNPJ...............: {funcionario.Empresa.Cnpj}");


            }



        }
    }
}
