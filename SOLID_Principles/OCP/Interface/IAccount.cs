using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Interface
{
    //Hesap adinda bir interface, IUser tipinde parametre alip, User tipinde kullanici olusturmamizi sagliyor.
    public interface IAccount
    {
        User Create(IUser account);
    }
}
