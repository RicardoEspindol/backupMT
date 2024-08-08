using EnumAndComposition.Entities;
using EnumAndComposition.Entities.Enums;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EnumAndComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order.ToString());
        }
    }
}