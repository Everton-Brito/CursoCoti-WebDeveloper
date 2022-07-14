using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Entities
{
    public class Paciente
    {
        //propriedades da classe [prop] + tab 2x
        public Guid IdPaciente { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<AtendimentoMedico> Atendimentos { get; set; }
    }
}
