using ProjetoAula01.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


//localização da classe no projeto
namespace ProjetoAula01.Repositorios
{
    //definição da classe
    public class ClienteRepositorio
    {
        //método para gravar os dados de um cliente em arquivo - void = nao devolve valor nenhum
        public void CadastrarCliente(Cliente cliente)
        {
            var diretorio = "c:\\temp";
            var arquivo = $"cliente_{cliente.IdCliente}.txt";

            //verificar se a pasta c:\\temp não existe
            if ( !Directory.Exists(diretorio))
                Directory.CreateDirectory(diretorio);    //criar a pasta / nao precisa de chaves para if com uma linha

            //abrindo um arquivo para gravação
            var streamWriter = new StreamWriter($"{diretorio}\\{arquivo}");

            //escrever os dados do arquivo
            streamWriter.WriteLine($"ID DO CLIENTE.........: {cliente.IdCliente}");
            streamWriter.WriteLine($"NOME.........: {cliente.Nome}");
            streamWriter.WriteLine($"EMAIL.........: {cliente.Email}");
            streamWriter.WriteLine($"TELEFONE.........: {cliente.Telefone}");
            streamWriter.WriteLine($"DATA DE CADASTRO.........: {cliente.DataCadastro}");

            //salvar e fechar o arquivo
            streamWriter.Flush();
            streamWriter.Close();


        }
    }
}
