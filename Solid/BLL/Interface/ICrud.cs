using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface ICrud<T> where T : BaseEntity
    {
        //Create
        string Create(T model);

        //Update
        string Update(T model);

        //Delete
        string Delete(int id);

        //Find by id
        T FindById(int id);
    }
}
