using ecommerce_app.Models;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Services
{
    public interface ICrudService<T,CreateDto,UpdateDto> where UpdateDto: class 
    {
        public T Get(int Id);

        public IEnumerable<T> GetAll();

        public T Create(CreateDto CreateDtoContent);

        public T Update(int Id, JsonPatchDocument<UpdateDto> UpdateDtoContent);

        public T Delete(int Id);
    }
}
