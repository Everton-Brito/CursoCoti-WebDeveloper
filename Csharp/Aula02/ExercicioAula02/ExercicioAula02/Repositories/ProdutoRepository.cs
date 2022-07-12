using Exercicio02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Repositories
{
    public class ProdutoRepository
    {
        //método para exportar dados do produto para arquivo
        public void Exportar(Produto produto)
        {
            //criando um arquiv
            using (var streamWriter = new StreamWriter($"c:\\temp\\produto_{produto.IdProduto}.txt"))
            {
                //escrevendo os dados do produto no arquivo
                streamWriter.WriteLine($"ID..................: {produto.IdProduto}");
                streamWriter.WriteLine($"NOME DO PRODUTO.....: {produto.Nome}");
                streamWriter.WriteLine($"PREÇO DO PRODUTO....: {produto.Preco}");
                streamWriter.WriteLine($"QUANTIDADE..........: {produto.Quantidade}");

            }
        }
    }
}
