using FormatLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FormatLib.OutputData
{
    public class OutputXmlData : IOutputData
    {
        public void WriteData(List<MusicialInstrument> instruments, string fileName)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter writer = XmlWriter.Create(fileName, settings))
            {
                writer.WriteStartElement("instruments");

                foreach (var item in instruments)
                {
                    writer.WriteStartElement("instrument");
                    writer.WriteAttributeString("name", item.Name);
                    writer.WriteAttributeString("description", item.Description);
                    writer.WriteAttributeString("creationYear", item.YearOfCreation.ToString());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
        }
    }
}
