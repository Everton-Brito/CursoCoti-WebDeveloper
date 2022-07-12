using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//localização da classe no projeto
namespace ProjetoAula01.Entidades
{

    //definição da classe
    public class Cliente
    {
        //prop + 2x [tab]
        public Guid IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
