﻿namespace InsecureDirectObjectReference.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
    }
}
