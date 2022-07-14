using ProjetoAula03.Controllers;

namespace ProjetoAula03
{
    public class Program
    {
        //Método para executar o projeto
        public static void Main(string[] args)
        {
            //instanciando a classe de controle
            var atendimentoControllers = new AtendimentoControllers();
            atendimentoControllers.CadastrarAtendimento();

            Console.ReadKey();
        }
    }
}
