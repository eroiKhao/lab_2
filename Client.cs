using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.IO;

namespace Car_Rental_System
{
    internal class Client : User
    {
        public string PassportDetails { get; set; }

        public Client () : base()
        {
            PassportDetails = string.Empty;
        }

        public Client(string name, string email, string passportDetails) : base(name, email)
        {
            PassportDetails = passportDetails;
        }

        public override string GetUserDetails()
        {
            return base.GetUserDetails() + $", Passport details: {PassportDetails}";
        }
        public void RentCar(string selectedCar, MaterialTextBox txtRentalDays, MaterialTextBox txtPassportDetails)
        {
            int rentalDays = int.TryParse(txtRentalDays.Text, out int days) ? days : 0;
            string passportDetails = txtPassportDetails.Text;

            if (!string.IsNullOrEmpty(selectedCar) && rentalDays > 0 && !string.IsNullOrEmpty(passportDetails))
            {
                int orderID = GetNextOrderID();

                string newOrder = $"{orderID},{selectedCar},{rentalDays},{passportDetails},Pending";

                List<string> orders = File.Exists("orders.txt") ? File.ReadAllLines("orders.txt").ToList() : new List<string>();

                orders.Add(newOrder);

                File.WriteAllLines("orders.txt", orders);

                MessageBox.Show($"Car: {selectedCar} rented for {rentalDays} days. Order ID: {orderID}. Passport: {passportDetails}");
            }
            else
            {
                MessageBox.Show("Please select a car, specify rental days, and enter passport details.");
            }
        }
        private int GetNextOrderID()
        {
            var orders = Order.LoadOrdersFromFile("orders.txt");
            return orders.Count > 0 ? orders.Max(o => o.OrderID) + 1 : 1;
        }
    }
}
