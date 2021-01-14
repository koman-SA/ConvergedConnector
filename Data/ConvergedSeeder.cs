using ConvergedConnector.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ConvergedConnector.Data
{
    public class ConvergedSeeder
    {
        private readonly PlatformContext  _ctx;
        private readonly IWebHostEnvironment _hosting;

        public ConvergedSeeder(PlatformContext ctx, IWebHostEnvironment hosting)
        {
            _ctx = ctx;
        }
        public void Seed()
        {
            _ctx.Database.EnsureCreated();

            if (!_ctx.Products.Any())
            {
                //Need to create sample data
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/art.json");
                var json = File.ReadAllText(filepath);
                var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(json);
                _ctx.Products.AddRange(products);
                    var order = _ctx.Orders.Where(o => o.Id == 1).FirstOrDefault();
                if (order!= null)
                {
                    order.Items = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                            Product = products.First(),
                            Quantity = 5,
                            UnitPrice = products.First().Price


                        }
                    };

                }

                    _ctx.SaveChanges();
            }
        }
    }
}
