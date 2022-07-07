using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Interface
{
    public interface IElectronics
    {
        //Electronic'in prorduct tipinde oldugunu belirtmek icin eklenen property:
        IProduct Electronic { get; set; }


    }
}
