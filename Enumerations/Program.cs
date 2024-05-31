using Enumerations;

class Program
{
    static void Main(string[] args)
    {
        var order = new Order(1,"John",OrderStatus.Pending,DateTime.Now);
        Console.WriteLine($"New order created: {order.OrderId}, Status: {order.Status}");


        order.UpdateStatus(OrderStatus.Processing);
        order.UpdateStatus(OrderStatus.Shipped);
        order.UpdateStatus(OrderStatus.Delivered);

        Console.WriteLine($"Final status of order {order.OrderId}: {order.Status}");
    }
}