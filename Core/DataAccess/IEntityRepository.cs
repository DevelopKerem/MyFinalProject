using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //*** CORE KATMANI DİĞER KATMANLARI REFERANS ALMAZ ***
    // generic constraint
    // class : referans tip
    // IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    // new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
                                       //filtre vermeyedebilir yani tüm data
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

                                    //filtreleyip getirecek
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
