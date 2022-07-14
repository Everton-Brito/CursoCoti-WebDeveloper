using Exercicio03.Controller;

namespace Exercicio03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var atendimentoController = new AtendimentoController();
            atendimentoController.CadastrarAtendimento();

            Console.ReadKey();
        }
    }
}