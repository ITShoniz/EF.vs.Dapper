using Framework.Repository;
using System.Collections.Generic;
using System.Linq;

namespace EntityFreamwork6Repository
{
    public class OrderRepositoryAsno : IRepository<Order>
    {
        WideWorldImportersEntities dbContext = new WideWorldImportersEntities();
        public Order GetById(long id)
        {
            return dbContext.Orders.Find(id);
        }
        public void Create(Order entity)
        {
            dbContext.Orders.Add(entity);
            dbContext.SaveChanges();
        }
        public void Delete(Order entity)
        {
            dbContext.Orders.Remove(entity);
            dbContext.SaveChanges();
        }
        public void Update(Order entity)
        {
            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }
        public List<Order> GetAll(int Top)
        {
            return dbContext.Orders.AsNoTracking().Take(Top).ToList();
        }
    }
}
