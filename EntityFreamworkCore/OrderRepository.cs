using Framework.Repository;
using System.Collections.Generic;
using System.Linq;

namespace EntityFreamworkCore
{
    public class OrderRepository : IRepository<Orders>
    {
        WideWorldImportersContext dbContext = new WideWorldImportersContext();
        public Orders GetById(long id)
        {
            return dbContext.Orders.Find(id);
        }
        public void Create(Orders entity)
        {
            dbContext.Orders.Add(entity);
            dbContext.SaveChanges();
        }
        public void Delete(Orders entity)
        {
            dbContext.Orders.Remove(entity);
            dbContext.SaveChanges();
        }
        public void Update(Orders entity)
        {
            dbContext.Entry(entity).State=Microsoft.EntityFrameworkCore.EntityState.Modified ;
            dbContext.SaveChanges();
        }
        public List<Orders> GetAll(int Top)
        {
            return dbContext.Orders.Take(Top).ToList();
        }
    }
}
