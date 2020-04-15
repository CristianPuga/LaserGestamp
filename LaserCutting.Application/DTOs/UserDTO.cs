using System;
using System.Collections.Generic;
using System.Text;

namespace LaserCutting.Application.DTOs
{
    public partial  class UserDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Role { get; set; }
        public string? Job { get; set; }
    }
}
