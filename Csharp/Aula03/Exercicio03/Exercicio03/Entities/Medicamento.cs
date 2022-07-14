using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Entities
{
    public class Medicamento
    {
        public Guid IdMedicamento { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<AtendimentoMedico> Atendimentos { get; set; }
    }
}
