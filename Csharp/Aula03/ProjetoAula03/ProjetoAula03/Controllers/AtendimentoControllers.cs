using ProjetoAula03.Entities;
using ProjetoAula03.Enums;
using ProjetoAula03.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula03.Controllers
{
    public class AtendimentoControllers
    {
        //método para ler todos os dados de um atendimento
        public void CadastrarAtendimento()
        {
            try
            {
                Console.WriteLine("\n***CADASTRO DE ATENDIMENTO***\n");
                //criando um objeto do tipo Atendimento
                var atendimento = new Atendimento();
                atendimento.Profissional = new Profissional();
                atendimento.Servicos = new List<Servico>();

                //gerando o id do atendimento:
                atendimento.Id = Guid.NewGuid();

                //capturando os dados do atendimento:
                
                Console.Write("Informe a data/hora do atendimento...............: ");
                atendimento.DataHora = DateTime.Parse(Console.ReadLine());

                Console.Write("Informe o valor do atendimento...................: ");
                atendimento.Valor = decimal.Parse(Console.ReadLine());

                Console.WriteLine("\nForma de pagamento.........................: ");
                Console.WriteLine("(1) Dinheiro");
                Console.WriteLine("(2) Débito");
                Console.WriteLine("(3) Crédito");
                Console.WriteLine("(4) Pix\n");

                Console.Write("Informe a forma de pagamento desejado............: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: atendimento.FormaDePagamento = FormaDePagamento.Dinheiro;
                        break;
                    case 2: atendimento.FormaDePagamento = FormaDePagamento.Debito;
                        break;
                    case 3: atendimento.FormaDePagamento = FormaDePagamento.Credito;
                        break;
                    case 4: atendimento.FormaDePagamento = FormaDePagamento.Pix;
                        break;
                   
                }
                //capturando os dados do profissional do atendimento
                atendimento.Profissional.Id = Guid.NewGuid();

                Console.Write("Informe o nome do profissional................................: ");
                atendimento.Profissional.Nome = Console.ReadLine();

                Console.Write("Informe o Cpf do profissional.................................: ");
                atendimento.Profissional.Cpf = Console.ReadLine();

                Console.Write("Informe a matrícula do profissional...........................: ");
                atendimento.Profissional.Matricula = Console.ReadLine();

                Console.Write("Informe a data de admissão do profissional....................: ");
                atendimento.Profissional.DataAdmissao = DateTime.Parse(Console.ReadLine());

                Console.Write("Informe o telefone do profissional............................: ");
                atendimento.Profissional.TelefoneContato = Console.ReadLine();

                Console.Write("Informe a quantidade de servicos..............................: ");
                var quantidade = int.Parse(Console.ReadLine());

                for (int i = 1; i <= quantidade; i++)
                {
                    Console.WriteLine($"\nEntre com o {i}º servico: ");

                    //criando uma variavel de instância para a entidade servico:
                    var servico = new Servico();

                    //gerando o id do serviço
                    servico.Id = Guid.NewGuid();

                    Console.Write("Informe o nome do serviço..................................: ");
                    servico.Nome = Console.ReadLine();

                    Console.Write("Informe a descrição do serviço.............................: ");
                    servico.Descricao = Console.ReadLine();

                    atendimento.Servicos.Add(servico);

                }

                //gravando os arquivos
                var atendimentoRepository = new AtendimentoRepository();
                atendimentoRepository.SalvarXML(atendimento);
                atendimentoRepository.SalvarJSON(atendimento);

                Console.WriteLine("\nDADOS GRAVADOS COM SUCESSO!");


            }
            catch (Exception e)
            {
                Console.WriteLine("\nFalha ao cadastrar atendimento!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
