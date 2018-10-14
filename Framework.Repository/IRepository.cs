using System;
using System.Collections.Generic;

namespace Framework.Repository
{
    public interface IRepository<T>
    {
        T GetById(Int64 id);

        void Create(T entity);

        void Delete(T entity);

        void Update(T entity);

        List<T> GetAll(int Top);
    }
}
