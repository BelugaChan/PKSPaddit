using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatLib.Interfaces
{
    public interface IOutputData
    {
        void WriteData(List<MusicialInstrument> instruments, string path);
    }
}
