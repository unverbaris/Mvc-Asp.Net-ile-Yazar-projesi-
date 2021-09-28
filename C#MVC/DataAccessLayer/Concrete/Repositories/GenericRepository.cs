using DataAccessLayer.Absract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {


        Context c = new Context();

        DbSet<T> _object;

        //constructor yapıcı methodlar 

        public GenericRepository()
        {
            _object = c.Set<T>(); //ARTIK OBJECT field dışardan gelen neyes o olcak t değeri
            
        }


        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter); //bir dizide ve ya listede sadece bir tane değer geriye döndürmek için kullanılan linq methodu
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();//filterdan gelen değere göre bana listele
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}
