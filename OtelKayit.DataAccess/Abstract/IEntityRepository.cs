using OtelKayit.Entities.Abstract;
using OtelKayit.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OtelKayit.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class , IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T GetCustomer(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
