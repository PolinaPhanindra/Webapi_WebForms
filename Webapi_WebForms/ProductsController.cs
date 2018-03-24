using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Webapi_WebForms.Models;

namespace Webapi_WebForms
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
          {
            new Product { Id = 1, Name = "John Walker", Category = "Liquior", Price = 1 },
            new Product { Id = 2, Name = "Alice ", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Chicken", Category = "White Meat", Price = 16.99M }

          };
       public IEnumerable<Product> GetAllDetails()
        {
            return products;
        }
        public IHttpActionResult GetProduct(int? id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if(product==null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        public IEnumerable<Product> GetProdcutBycategory(string cat)
        {
            return products.Where((p) => string.Equals(p.Category, cat, StringComparison.OrdinalIgnoreCase));
        }
    }
}