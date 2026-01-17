using ecommerce_app.Dtos;
using ecommerce_app.Models;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Services
{

    public class TransactionsService : ITransactionsService
    {
        private readonly EcommerceAppContext db = new EcommerceAppContext();
        

        public Transaction Create(CreateTransactionDto CreateDtoContent)
        {
            throw new NotImplementedException();
        }


        public Transaction Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Transaction Get(int Id)
        {
            return db.Transaction.Find(Id);
        }

        public IEnumerable<Transaction> GetAll()
        {
            return db.Transaction.ToList();
        }


        public Transaction Update(int Id, JsonPatchDocument<UpdateTransactionDto> UpdateDtoContent)
        {
            throw new NotImplementedException();
        }
    }
}
