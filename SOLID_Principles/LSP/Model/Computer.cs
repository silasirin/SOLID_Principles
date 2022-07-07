using LSP.Entity;
using LSP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Model
{
    public class Computer: BaseProduct, IElectronic
    {
        //Computer hem base bir product'tir, hem de electronic turune aittir. Bu nedenle her iki kisimdan da miras alir.
    }
}
