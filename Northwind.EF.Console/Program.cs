using System;
using System.Linq;
using Northwind.EF.Console.Models;

namespace northwind.ef.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new NorthwindDbContext();

            // 建立資料庫
            db.Database.EnsureCreated();

            // 建立一筆資料並取出顯示
            var orders = db.Orders.ToList();

            if (!orders.Any())
            {
                db.Orders.Add(new Order
                {
                    ShipName = "jGame"
                });
                db.SaveChanges();

                orders = db.Orders.ToList();
            }

            foreach (var order in orders)
            {
                Console.WriteLine(order.ShipName);
            }
        }
    }
}
