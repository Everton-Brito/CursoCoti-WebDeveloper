using Exercicio03.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercicio03.Repositories
{
    public class AtendimentoRepository
    {
        public void SalvarXML(AtendimentoMedico atendimentoMedico)
        {
            var xml = new XmlSerializer(typeof(AtendimentoMedico));
            using (var streamWriter = new StreamWriter($"c:\\temp\\atendimentoMedico_{atendimentoMedico.IdAtendimento}.xml"))
            {
                xml.Serialize(streamWriter, atendimentoMedico);
            }
        }

        public void SalvarJSON(AtendimentoMedico atendimentoMedico)
        {
            var json = JsonConvert.SerializeObject(atendimentoMedico, Formatting.Indented);

            using (var streamWriter = new StreamWriter($"c:\\temp\\atendimentoMedico_{atendimentoMedico.IdAtendimento}.json"))
            {
                streamWriter.WriteLine(json);
            }
        }
    }
}
