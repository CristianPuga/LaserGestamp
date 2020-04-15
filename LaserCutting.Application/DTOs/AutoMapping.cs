using AutoMapper;
using LaserCutting.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaserCutting.Application.DTOs
{
    public class AutoMapping: Profile
    {
        public AutoMapping() 
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
