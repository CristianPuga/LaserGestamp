﻿using System;

namespace LaserCutting.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public string? Role { get; set; }
        public string? Job { get; set; }
        public string? Token { get; set; }

    }
}
