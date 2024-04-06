using FormatLib.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatLib.OutputData
{
    public class OutputJsonData : IOutputData
    {
        public void WriteData(List<MusicialInstrument> instruments, string path)
        {
            string json = JsonConvert.SerializeObject(instruments, Formatting.Indented);
            File.WriteAllText(path, json);
        }
    }
}
