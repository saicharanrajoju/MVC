using ecommerce_app.Dtos;
using ecommerce_app.Models;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Services
{
    public class ProductsService : IProductsService
    {
        private readonly EcommerceAppContext db = new EcommerceAppContext();

        public Product Create(CreateProductDto CreateDtoContent)
        {
            throw new NotImplementedException();
        }


        public Product Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int Id)
        {
            return db.Product.Find(Id);
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Product.ToList();
        }

        public Product Update(int Id, JsonPatchDocument<UpdateProductDto> UpdateDtoContent)
        {
            throw new NotImplementedException();
        }
    }
}
