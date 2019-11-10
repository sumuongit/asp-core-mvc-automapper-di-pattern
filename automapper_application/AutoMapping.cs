using AutoMapper;
using automapper_application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace automapper_application
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<User, UserDTO>(); // means you want to map from User to UserDTO
        }
    }
}
