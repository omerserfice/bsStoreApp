using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IRepositoryBase<T>
    {
        // trackChanges ifadesi değişiklikleri izleyip izlemeyeceğini belirten parametre.
        IQueryable<T> FindAll(bool trackChanges); // tüm listeleri getiren bir method.
        IQueryable<T> FindByCondition(Expression<Func<T,bool>> expression,bool trackChanges); // koşula bağlı olarak bir liste alan method bune ek olarak bir  Expression ifadesi 
        // yazacağız.
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);



    }
}
