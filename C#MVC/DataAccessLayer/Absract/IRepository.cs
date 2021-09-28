using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Absract
{
    public interface IRepository<T>
    {
        List<T> List();

        void Insert(T p);

        T Get(Expression<Func<T, bool>> filter);//tek bulma methodu 

        void Delete(T p);

        void Update(T p);

        List<T> List(Expression<Func<T,bool>>filter); //filtreleme bulma  tüm listeyi buluyor



    }
}
