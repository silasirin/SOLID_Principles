using BLL.Interface;
using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class UserService<T> : IListe<T> where T: BaseEntity
    {
        SolidContext db = new SolidContext();

        public List<T> GetList()
        {
            return db.Set(typeof(T)).Cast<T>().ToList();
        }
    }
}
