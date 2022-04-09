using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Core katmanı hiçbir yere bağlı olmaz!!

    //Generic Constraint
    //Class : Referans Tip
    //IEntity : IEntity olabilir ya da IEntity implement eden sınıflar olabilir.
    //new : new'lenebilir olmalı.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
