using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsuarios()
        {
            List<User> user = new List<User>();

            // Add parts to the list.
            user.Add(new User() { Id = 1,  Username = "crank arm", Password = "1234" });
            user.Add(new User() { Id = 2, Username = "crank arm", Password = "1234" });
            user.Add(new User() { Id = 3, Username = "crank arm", Password = "1234" });
            user.Add(new User() { Id = 4, Username = "crank arm", Password = "1234" });
            user.Add(new User() { Id = 5, Username = "crank arm", Password = "1234" });
            user.Add(new User() { Id = 6, Username = "crank arm", Password = "1234" });
            return Ok(user);
        }
    }
}