using Microsoft.AspNetCore.Mvc;
using Store.API.Models;
using Store.API.Repositories;
using System.Collections.Generic;

namespace Store.API.Controllers
{
    [Route("v1")]
    public class HomeController : Controller
    {
        private readonly ProductRepository productRepository;
        public HomeController(ProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }
        [Route("products")]
        [HttpGet]
        public IEnumerable<Product> get()
        {
            return productRepository.Get();         
        }
        [Route("products")]
        [HttpPost]
        public string Post(Product product)
        {
            productRepository.Create(product);
            return "Inserido com sucesso";
        }
    }
}
