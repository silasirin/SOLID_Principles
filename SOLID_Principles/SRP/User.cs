using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    //SOLID prensiplerinden ilki olan "Single Responsibility Principle", proje icerisindeki tum class ve method'larin yalnizca birer sorumlulugu olmasi gerektigini savunur. Temel amaci okunabilirligi kolaylastirmaktir.
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsStandard { get; set; }
        public bool IsGold { get; set; }
        public bool IsPremium { get; set; }
    }
}
