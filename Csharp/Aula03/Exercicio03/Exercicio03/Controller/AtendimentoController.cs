using Exercicio03.Entities;
using Exercicio03.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Controller
{
    public class AtendimentoController
    {
        public void CadastrarAtendimento()
        {
            try
            {
                Console.WriteLine("\n***CADASTRO DE ATENDIMENTO***\n");
                //criando um objeto do tipo Atendimento
                var atendimentoMedico = new AtendimentoMedico();
                atendimentoMedico.Medico = new Medico();
                atendimentoMedico.Paciente = new Paciente();
                atendimentoMedico.Medicamentos = new List<Medicamento>();

                //gerando o id do atendimento:
                atendimentoMedico.IdAtendimento = Guid.NewGuid();

                //capturando os dados do atendimento
                Console.Write("informe a data/hora do atendimento...............: ");
                atendimentoMedico.DataHora = Console.ReadLine();
                Console.Write("Informe o valor do atendimento...................: ");
                atendimentoMedico.Valor = decimal.Parse(Console.ReadLine());

                //capturando os dados do paciente do atendimento
                atendimentoMedico.Paciente.IdPaciente = Guid.NewGuid();

                Console.Write("Informe o nome do paciente.......................: ");
                atendimentoMedico.Paciente.Nome = Console.ReadLine();

                Console.Write("Informe a data de nascimento do paciente.........: ");
                atendimentoMedico.Paciente.DataNascimento = DateTime.Parse(Console.ReadLine());

                //capturando os dados do medico do atendimento
                atendimentoMedico.Medico.IdMedico = Guid.NewGuid();

                Console.Write("Informe o nome do medico.........................: ");
                atendimentoMedico.Medico.Nome = Console.ReadLine();

                Console.Write("Informe o CRM do medico..........................: ");
                atendimentoMedico.Medico.CRM = Console.ReadLine();

                //Dados do medicamento
                Console.Write("Informe a quantidade de medicamentos.............: ");
                var quantidade = int.Parse(Console.ReadLine());

                for (int i = 1; i <= quantidade; i++)
                {
                    Console.WriteLine($"\nEntre com o {i}º medicamento:");

                    var medicamento = new Medicamento();

                    medicamento.IdMedicamento = Guid.NewGuid();
                    Console.Write("Informe o nome do medicamento...............: ");
                    medicamento.Nome = Console.ReadLine();

                    Console.Write("Informe a descricao do medicamento..........: ");
                    medicamento.Descricao = Console.ReadLine();

                    //adicionando a quantidade de medicamento ao atendimento medico
                    atendimentoMedico.Medicamentos.Add(medicamento);

                }

                var atendimentoRepository = new AtendimentoRepository();

                atendimentoRepository.SalvarXML(atendimentoMedico);
                atendimentoRepository.SalvarJSON(atendimentoMedico);

                Console.WriteLine("\nDADOS GRAVADOS COM SUCESSO!");



            }
            catch (Exception e)
            {
                Console.WriteLine("\nFALHA AO CADASTRAR ATENDIMENTO!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
