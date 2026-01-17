using AutoMapper;
using ecommerce_app.Dtos;
using ecommerce_app.Models;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ecommerce_app.Services
{
    public class UsersService : IUsersService
    {
        private readonly EcommerceAppContext db = new EcommerceAppContext();
        private readonly IMapper _mapper;

        public UsersService()
        {
                
        }

        public UsersService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public User Get(int Id)
        {
            return db.User.Find(Id);
        }

        public IEnumerable<User> GetAll()
        {
            return db.User.ToList();
        }

        public User GetUserByEmail(string Email)
        {
            return db.User.Where(user => user.Email == Email).FirstOrDefault();
        }

        public User Create(CreateUserDto CreateDtoContent)
        {
            var UserToBeCreated = _mapper.Map<User>(CreateDtoContent);
            var CreatedUser = db.User.Add(UserToBeCreated).Entity;
            db.SaveChanges();
            return CreatedUser;
        }

        public User Update(int Id, JsonPatchDocument<UpdateUserDto> UpdateDtoContent)
        {
            var UserToBeUpdated = this.Get(Id);
            if (UserToBeUpdated == null) return null;
            var UpdatedUser = _mapper.Map(UpdateDtoContent, UserToBeUpdated);
            return UpdatedUser;
        }

        public User Delete(int Id)
        {
            var UserToBeDeleted = this.Get(Id);
            db.User.Remove(UserToBeDeleted);
            db.SaveChanges();
            return UserToBeDeleted;
        }
    }
}
