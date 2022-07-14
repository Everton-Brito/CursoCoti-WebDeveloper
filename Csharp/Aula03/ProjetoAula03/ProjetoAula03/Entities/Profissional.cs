using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula03.Entities
{
    // Profissional Herda(:) pessoa 
    public class Profissional : Pessoa
    {
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string TelefoneContato { get; set; }
        public List<Atendimento> Atendimentos { get; set; }
    }
}
