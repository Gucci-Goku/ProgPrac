using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using APIDemo.Models;

namespace APIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("Product")]// for this method to be executed, the URL will be the name of the controller and the name of the route which is product
        public string returnProduct()
        {
           

            return "Eggs";
        }

        [HttpGet]
        [Route("All")]
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product(1,"Coke"),
                new Product(2,"Red Bull"),
                new Product(4,"Prime"),
                new Product(6,"Bread"),
                new Product(8,"Chicken"),
                new Product(10,"Fruit"),
            };
        }



    }
}
