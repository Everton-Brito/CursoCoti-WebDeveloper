using ProjetoAula02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula02.Repositories
{
    public class EmpresaRepository
    {
        public void Exportar(Empresa empresa)
        {
            using (var streamWriter = new StreamWriter($"c:\\temp\\empresa_{empresa.IdEmpresa}.txt"))
            {
                streamWriter.WriteLine($"ID...............: {empresa.IdEmpresa}");
                streamWriter.WriteLine($"Nome Fantasia....: {empresa.NomeFantasia}");
                streamWriter.WriteLine($"Razao Social.....: {empresa.RazaoSocial}");
                streamWriter.WriteLine($"CNPJ.............: {empresa.Cnpj}");

            }
        }

    }
}
