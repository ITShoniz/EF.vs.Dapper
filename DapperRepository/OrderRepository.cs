using Dapper;
using Framework.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace DapperRepository
{
    public class OrderRepository : IRepository<Order>
    {
        IDbConnection db = new SqlConnection("data source=.;initial catalog=WideWorldImporters;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        public Order GetById(long id)
        {
            throw new NotImplementedException();
        }
        public void Create(Order entity)
        {
            string InsertQuery = @"INSERT INTO [Sales].[Orders]
           ([OrderID]
           ,[CustomerID]
           ,[SalespersonPersonID]
           ,[PickedByPersonID]
           ,[ContactPersonID]
           ,[BackorderOrderID]
           ,[OrderDate]
           ,[ExpectedDeliveryDate]
           ,[CustomerPurchaseOrderNumber]
           ,[IsUndersupplyBackordered]
           ,[Comments]
           ,[DeliveryInstructions]
           ,[InternalComments]
           ,[PickingCompletedWhen]
           ,[LastEditedBy]
           ,[LastEditedWhen])
     VALUES
           (" + entity.OrderID +
          "," + entity.CustomerID +
          "," + entity.SalespersonPersonID +
          "," + entity.PickedByPersonID +
          "," + entity.ContactPersonID +
          "," + entity.BackorderOrderID +
          "," + entity.OrderDate +
          "," + entity.ExpectedDeliveryDate +
          "," + entity.CustomerPurchaseOrderNumber +
          "," + entity.IsUndersupplyBackordered +
          "," + entity.Comments +
          "," + entity.DeliveryInstructions +
          "," + entity.InternalComments +
          "," + entity.PickingCompletedWhen +
          "," + entity.LastEditedBy +
          "," + entity.LastEditedWhen + ")";


            db.Query(InsertQuery);

        }
        public void Delete(Order entity)
        {
            throw new NotImplementedException();
        }
        public void Update(Order entity)
        {
            string UpdateQuery = @"UPDATE [Sales].[Orders]
                            SET 
                               ,[CustomerID] = " + entity.CustomerID.ToString() +
                    ",[SalespersonPersonID] = " + entity.SalespersonPersonID.ToString() +
                    ",[PickedByPersonID] =" + entity.PickedByPersonID.ToString() +
                    ",[ContactPersonID] = " + entity.ContactPersonID.ToString() +
                    ",[BackorderOrderID] =" + entity.BackorderOrderID.ToString() +
                    ",[OrderDate] = '" + entity.OrderDate.ToString() + "'" +
                    ",[ExpectedDeliveryDate] = '" + entity.ExpectedDeliveryDate.ToString() + "'" +
                    ",[CustomerPurchaseOrderNumber] =  '" + entity.CustomerPurchaseOrderNumber.ToString() + "'" +
                    ",[IsUndersupplyBackordered] = " + ((entity.IsUndersupplyBackordered == true) ? "1" : "0") +
                    ",[Comments] = '" + entity.Comments.ToString() + "'" +
                    ",[DeliveryInstructions] = '" + entity.DeliveryInstructions.ToString() + "'" +
                    ",[InternalComments] = '" + entity.InternalComments.ToString() + "'" +
                    ",[PickingCompletedWhen] = '" + entity.PickingCompletedWhen.ToString() + "'" +
                    ",[LastEditedBy] = '" + entity.LastEditedBy.ToString() + "'" +
                    ",[LastEditedWhen] = '" + entity.LastEditedWhen.ToString() + "'" +
                    "WHERE OrderID=" + entity.OrderID.ToString();
            db.Query(UpdateQuery);
        }
        public List<Order> GetAll(int Top)
        {

            return db.Query<Order>("Select top "+  Top.ToString() + " * From Sales.Orders ").ToList();
        }
    }
}
