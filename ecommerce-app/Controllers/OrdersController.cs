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
    public class OrdersController : Controller
    {
        private readonly IOrdersService _ordersService;

        public OrdersController(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }
        [HttpGet]
        public IEnumerable<Order> Index()
        {
            return _ordersService.GetAll();
        }

        [HttpGet("{id:int}")]
        public Order Get(int Id)
        {
            return _ordersService.Get(Id);
        }

    }
}
