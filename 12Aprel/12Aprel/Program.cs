using System;
using ClassLibrary;
namespace _12Aprel
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order();
            order1.No = 12;
            order1.CreatedAt = new DateTime(2001,03,02);
            order1.TotalAmount = 40;

            Order order2 = new Order();
            order2.No = 24;
            order2.CreatedAt = new DateTime(2009, 03, 02);
            order2.TotalAmount = 50;

            Order order3 = new Order();
            order3.No = 12;
            order3.CreatedAt = new DateTime(2010, 03, 02);
            order3.TotalAmount = 30;

            Order order4 = new Order();
            order4.No = 17;
            order4.CreatedAt = new DateTime(2001, 03, 02);
            order4.TotalAmount = 30;

            Shop newShop = new Shop();
            newShop.AddOrder(order1);
            newShop.AddOrder(order2);
            newShop.AddOrder(order3);
            newShop.AddOrder(order4);
            /*foreach (var item in newShop.FilterOrderByPrice(10, 50))
            {
                Console.WriteLine(item.No);
            }*/

            /* newShop.RemoveOrderByNo(12);
             foreach (var item in newShop.Orders)
             {
                 Console.WriteLine(item.No);
             }*/

            /*DateTime check = new DateTime(2003, 01, 01);
            Console.WriteLine(newShop.GetOrdersAvg(check));*/

            /*Console.WriteLine(newShop.GetOrdersAvg(newShop.Orders)); */

        }
        
        
    }
}
