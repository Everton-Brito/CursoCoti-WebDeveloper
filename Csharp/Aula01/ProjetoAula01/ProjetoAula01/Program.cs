using ProjetoAula01.Entidades;
using ProjetoAula01.Repositorios;

//Localização da classe no projeto
namespace ProjetoAula01
{
    //declaração da classe
    public class Program
    {
        //método (função) utilizada para executar o projeto
        public static void Main(string[] args)
        {
            Console.WriteLine("\n *** CADASTRO DE CLIENTES *** \n");

            //variável de instância / objeto
            var cliente = new Cliente();

            cliente.IdCliente = Guid.NewGuid();

            Console.Write("INFORME O NOME DO CLIENTE.....: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("INFORME O EMAIL DO CLIENTE....: ");
            cliente.Email = Console.ReadLine();

            Console.Write("INFORME O TELEFONE DO CLIENTE.: ");
            cliente.Telefone = Console.ReadLine();

            cliente.DataCadastro = DateTime.Now;

             //imprimindo os dados
            Console.WriteLine("\nDADOS DO CLIENTE:");
            Console.WriteLine($"\tID DO CLIENTE.........: {cliente.IdCliente}");
            Console.WriteLine($"\tNOME DO CLIENTE.......: {cliente.Nome}");
            Console.WriteLine($"\tEMAIL.................: {cliente.Email}");
            Console.WriteLine($"\tTELEFONE..............: {cliente.Telefone}");
            Console.WriteLine($"\tDATA DE CADASTRO......: {cliente.DataCadastro}");

            //variável de instância / objeto
            var clienteRepositorio = new ClienteRepositorio();
            //cadastrando o cliente
            clienteRepositorio.CadastrarCliente(cliente);

            Console.WriteLine("\nARQUIVO GRAVADO COM SUCESSO!");

            Console.ReadKey();
        }
    }
}



