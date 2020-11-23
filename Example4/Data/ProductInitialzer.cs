using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Data.Entity;
using Example4.Models;
namespace Example4.Data
{
    public class ProductInitialzer
    {
        public static void Initialize(NorthWindContext context)
        {
            context.Database.EnsureCreated();
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            var products = new Product[]
            {
            //new Product { ProductName = "Carson", Category = "A", UnitPrice = 12, UnitsInStock = 12 },
            //new Product { ProductName = "Meredith", Category = "A", UnitPrice = 1, UnitsInStock = 7 },
            //new Product { ProductName = "Arturo", Category = "A", UnitPrice = 100, UnitsInStock = 9 },
            //new Product { ProductName = "Gytis", Category = "B", UnitPrice = 20, UnitsInStock = 56 },
            //new Product { ProductName = "Yan", Category = "C", UnitPrice = 30, UnitsInStock = 8 },
            //new Product { ProductName = "Peggy", Category = "D", UnitPrice = 3, UnitsInStock = 7 },
            //new Product { ProductName = "Laura", Category = "E", UnitPrice = 4, UnitsInStock = 8 },
            //new Product { ProductName = "Nino", Category = "F", UnitPrice = 9, UnitsInStock = 2 }
            };
            foreach (Product s in products)
            {
                context.Products.Add(s);
            }
            context.SaveChanges();
        }
    }
}






