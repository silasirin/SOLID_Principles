using LSP.Entity;
using LSP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Model
{
    public class Product : BaseProduct, IElectronics
    {
        //Product base producttir, electronic'in bir product oldugunu tanimladigimiz IElectronics interface'inden kalitim aliriz. 
        public IProduct Electronic { get; set; }

        public virtual void ElectronicProduct(IProduct product)
        {
            Electronic = product;
        }
    }
}
