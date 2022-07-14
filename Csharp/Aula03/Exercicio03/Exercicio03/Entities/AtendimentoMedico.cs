using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Entities
{
    public class AtendimentoMedico
    {
        public Guid IdAtendimento { get; set; }
        public string DataHora { get; set; }
        public decimal Valor { get; set; }
        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }
        public List<Medicamento> Medicamentos { get; set; }
    }
}
