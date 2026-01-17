using ecommerce_app.Models;
using ecommerce_app.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : Controller
    {
        private readonly ITransactionsService _transactionsService;
        public TransactionsController(ITransactionsService transactionsService)
        {
            _transactionsService = transactionsService;

        }
        [HttpGet]
        public IEnumerable<Transaction> Index()
        {

            return _transactionsService.GetAll();

        }
        [HttpGet("{id:int}")]
        public Transaction Get(int Id)
        {
            return _transactionsService.Get(Id);
        }
    }
}
