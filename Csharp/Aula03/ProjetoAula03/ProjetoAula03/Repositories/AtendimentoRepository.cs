using Newtonsoft.Json;
using ProjetoAula03.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjetoAula03.Repositories
{
    public class AtendimentoRepository
    {
        //método para salvar os dados do atendimento em arquivo xml
        public void SalvarXML(Atendimento atendimento)
        {
            //serializar os dados do objeto que será gravado em xml
            var xml = new XmlSerializer(typeof(Atendimento));

            //criar arquivo de extensão.xml
            using (var streamWriter = new StreamWriter($"c:\\temp\\atendimento_{atendimento.Id}.xml"))
            {
                //gravar os dados do arquivo
                xml.Serialize(streamWriter, atendimento);

            }
        }

        //método para salvar os dados do atendimento em arquivo JSON
        public void SalvarJSON(Atendimento atendimento)
        {
            //serializar os dados do objeto que será gravado em JSON
            var json = JsonConvert.SerializeObject(atendimento, Formatting.Indented);

            //criar um arquivo de extensão .json
            using (var streamWriter = new StreamWriter($"c:\\temp\\atendimento_{atendimento.Id}.json"))
            {
                //gravar os dados do arquivo
                streamWriter.WriteLine(json);
            }

        }
    }
}
