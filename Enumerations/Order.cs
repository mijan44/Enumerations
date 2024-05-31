using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(int orderId, string customerName, OrderStatus status,DateTime orderDate)
        {
            OrderId = orderId;
            CustomerName = customerName;
            Status = status;
            OrderDate = orderDate;
        }

        public void UpdateStatus(OrderStatus newStatus)
        {
            Status=newStatus;
            Console.WriteLine($"Order {OrderId} status updated to {Status}");
        }

    }
}
