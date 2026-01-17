using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ecommerce_app.Dtos;
using ecommerce_app.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.JsonPatch.Operations;

namespace ecommerce_app.Profiles
{
    public class UserDtoProfile: Profile
    {
        public UserDtoProfile()
        {
            CreateMap<CreateUserDto, User>();
            CreateMap<JsonPatchDocument<UpdateUserDto>, JsonPatchDocument<User>>();
            CreateMap<Operation<UpdateUserDto>, Operation<User>>();
        }
    }
}
