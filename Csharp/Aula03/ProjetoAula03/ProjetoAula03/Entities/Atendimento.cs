using ProjetoAula03.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula03.Entities
{
    public class Atendimento
    {
        public Guid Id { get; set; }
        public DateTime DataHora { get; set; }
        public decimal  Valor { get; set; }
            // tipo       nome
        public Profissional Profissional { get; set; }
        public List<Servico> Servicos { get; set; }
        public FormaDePagamento FormaDePagamento { get; set; }
    }

}
