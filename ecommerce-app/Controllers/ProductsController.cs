using ecommerce_app.Models;
using ecommerce_app.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        public IEnumerable<Product> Index()
        {
            return _productsService.GetAll();
        }

        [HttpGet("{id:int}")]
        public Product Get(int Id)
        {
            return _productsService.Get(Id);
        }
    }
}
