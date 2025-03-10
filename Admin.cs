using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Car_Rental_System
{
    internal class Admin : User
    {
        public string Role { get; set; }
        public Admin() : base()
        {
            Role = "Owner";
        }
        public Admin(string name, string email, string role) : base(name, email)
        {
            Role = role;
        }
        public new string GetUserDetails()
        {
            return $"Admin: {Name}, Email: {Email}, Role: {Role}";
        }
    }
}
