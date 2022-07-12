using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//localização da classe no projeto
namespace ExercicioAula1.Entities
{
    //definição da classe
    public class Funcionario
    {
        //prop + 2x[tab]
        public Guid IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }
    }
}
