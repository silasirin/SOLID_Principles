using BLL.Interface;
using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class AdminService<T> : IListe<T>,ICrud<T> where T : BaseEntity
    {
        SolidContext db = new SolidContext();
        public string Create(T model)
        {
            string result = "";
            try
            {
                db.Set(typeof(T)).Add(model); //category, product vs T'nin tipine bak. Eger ilgili tablo varsa ona set et ve girilen model tipini ilgili tabloya ekle.
                db.SaveChanges();
                result = $"Veri kaydedildi.";
                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return result;
            }
        }

        public string Delete(int id)
        {
            try
            {
                var deleted = db.Set(typeof(T)).Find(id);
                db.Set(typeof(T)).Remove(deleted);
                db.SaveChanges();
                return "Silme islemi basarili.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<T> GetList()
        {
            return db.Set(typeof(T)).Cast<T>().ToList();
        }

        public string Update(T model)
        {
            try
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Guncelleme basarili.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public T FindById(int id)
        {
            return db.Set(typeof(T)).Cast<T>().Find(id);
        }
    }
}
