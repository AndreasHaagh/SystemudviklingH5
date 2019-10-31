using System;
using SystemUdviklingH5.Models;
using System.Collections.Generic;
using System.Text;

namespace SystemUdviklingH5.Employee
{
    class OrderList
    {
        public static List<Order> orders = new List<Order>();

        public static void DisplayOrderList()
        {
            Console.WriteLine("Here are the list of orders: ");
            foreach (var order in orders)
            {
                Console.WriteLine("Order id: " + order.id);
            }
        }
    }
}
