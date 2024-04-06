using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatLib.Interfaces
{
    public interface IInputData
    {
        public List<MusicialInstrument> GetData(string path);
    }
}
