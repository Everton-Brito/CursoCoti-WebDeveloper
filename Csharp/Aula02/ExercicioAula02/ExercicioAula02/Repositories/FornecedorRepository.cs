using Exercicio02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Repositories
{
    public class FornecedorRepository
    {
        //método para exportar dados do produto para arquivo
        public void Exportar(Fornecedor fornecedor)
        {
            using (var streamWriter = new StreamWriter($"c:\\temp\\fornecedor_{fornecedor.IdFornecedor}.txt"))
            {
                //escrevendo os dados do produto no arquivo
                streamWriter.WriteLine($"ID..............: {fornecedor.IdFornecedor}");
                streamWriter.WriteLine($"NOME............: {fornecedor.Nome}");
                streamWriter.WriteLine($"CNPJ............: {fornecedor.Cnpj}");
            }
;

        }
    }
}
