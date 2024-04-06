using FormatLib.Interfaces;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatLib.InputData
{
    public class InputCsvData : IInputData
    {
        private List<MusicialInstrument> musicialInstruments = new List<MusicialInstrument>();

        public List<MusicialInstrument> GetData(string path)
        {
            using (TextFieldParser parser = new TextFieldParser(path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                string[] headers = parser.ReadFields();
                while (!parser.EndOfData)
                {
                    MusicialInstrument instrument = new MusicialInstrument();

                    string[] fields = parser.ReadFields();
                    instrument.Name = fields[0];
                    instrument.Description = fields[1];
                    instrument.YearOfCreation = int.Parse(fields[2]);
                    musicialInstruments.Add(instrument);
                }
            }
            return musicialInstruments;
        }
    }
}
