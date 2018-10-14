using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperRepository
{
    public partial class Order
    {     
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int SalespersonPersonID { get; set; }
        public Nullable<int> PickedByPersonID { get; set; }
        public int ContactPersonID { get; set; }
        public Nullable<int> BackorderOrderID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime ExpectedDeliveryDate { get; set; }
        public string CustomerPurchaseOrderNumber { get; set; }
        public bool IsUndersupplyBackordered { get; set; }
        public string Comments { get; set; }
        public string DeliveryInstructions { get; set; }
        public string InternalComments { get; set; }
        public Nullable<System.DateTime> PickingCompletedWhen { get; set; }
        public int LastEditedBy { get; set; }
        public System.DateTime LastEditedWhen { get; set; }

    }
}
