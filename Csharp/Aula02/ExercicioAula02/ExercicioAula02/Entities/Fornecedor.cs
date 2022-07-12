using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Entities
{
    public class Fornecedor
    {
        #region Propriedades
        public Guid IdFornecedor { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public List<Produto> Produto { get; set; }
        #endregion

    }
}
