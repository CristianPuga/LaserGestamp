using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LaserCutting.Application.DTOs;
using LaserCutting.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaserCutting.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IMapper _mapper;

        public UsuariosController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserDTO>> GetUsuarios()
        {
            User user = new User()
            {
                Id = 1,
                Username = "crank arm",
                Password = "1234",
                Email = "Juan@gmail.com",
                Job = "Director",
                Role = "Administrator",
                Token = "hjuksfhuususuifsuifduifhsdu"
            };


            var mapping = _mapper.Map<UserDTO>(user);

            return Ok(mapping);
        }
    }
}