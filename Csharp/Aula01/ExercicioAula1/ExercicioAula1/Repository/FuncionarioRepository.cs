using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioAula1.Entities;
using System.IO;

//localização da classe no projeto
namespace ExercicioAula1.Repository
{
    //definição da classe
    public class FuncionarioRepository
    {
        //método para gravar os dados de um cliente em arquivo
        public void CadastrarFuncionario(Funcionario funcionario)
        {
            var diretorio = "c:\\temp";
            var arquivo = $"Funcionario_{funcionario.IdFuncionario}.txt";

            //verificar se a pasta não existe
            if (!Directory.Exists(diretorio))
                Directory.CreateDirectory(diretorio);//Criar pasta (if quando so possue uma linha nao precisa usar {})
            //abrindo arquivo para gravação
            var streamWriter = new StreamWriter($"{diretorio}\\{arquivo}");

            //escrever dados do arquivo
            streamWriter.WriteLine($"ID DO FUNCIONARIO.......: {funcionario.IdFuncionario}");
            streamWriter.WriteLine($"NOME DO FUNCIONARIO.....: {funcionario.Nome}");
            streamWriter.WriteLine($"CPF DO FUNCIONARIO......: {funcionario.Cpf}");
            streamWriter.WriteLine($"MATRICULA DO FUNCIONARIO: {funcionario.Matricula}");
            streamWriter.WriteLine($"DATA DA ADMISSAO........: {funcionario.DataAdmissao}");

            //salvar e fechar arquivo
            streamWriter.Flush();
            streamWriter.Close();
        }

    }
}
