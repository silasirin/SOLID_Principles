using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Interface
{
    //Kullanicilarin olusturdugu bir interface. Icerisinde kullanicilarin tum property'leri tanimli.
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Password { get; set; }
        string Email { get; set; }

        IAccount GenerateAccount { get; set; }
    }
}
