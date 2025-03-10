using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System
{
    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public User()
        {
            Name = "Unknown";
            Email = "Unknown";
        }
        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public virtual string GetUserDetails()
        {
            return $"User: {Name}, Email: {Email}";
        }
    }
}
