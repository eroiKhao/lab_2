using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Car_Rental_System
{
    internal class Order
    {
        public int OrderID { get; set; }
        public string Car { get; set; }
        public int RentalDays { get; set; }
        public string PassportDetails { get; set; }
        public string RejectionReason { get; set; }
        public string Status { get; set; }

        public Order(int orderID, string car, int rentalDays, string passportDetails, string status = "Pending")
        {
            OrderID = orderID;
            Car = car;
            RentalDays = rentalDays;
            PassportDetails = passportDetails;
            Status = status;
            RejectionReason = string.Empty;
        }

        public static void SaveOrdersToFile(string filePath, List<Order> orders)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var order in orders)
                {
                    writer.WriteLine($"{order.OrderID},{order.Car},{order.RentalDays},{order.PassportDetails},{order.Status},{order.RejectionReason}");
                }
            }
        }
        public static List<Order> LoadOrdersFromFile(string filePath)
        {
            var orders = new List<Order>();
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length >= 5)
                {
                    var order = new Order(
                        int.Parse(parts[0]),
                        parts[1],
                        int.Parse(parts[2]),
                        parts[3],
                        parts[4]
                    );
                    order.RejectionReason = parts.Length > 5 ? parts[5] : string.Empty;
                    orders.Add(order);
                }
            }

            return orders;
        }
        public static void CompletePayment(string orderID)
        {
            var orders = LoadOrdersFromFile("orders.txt");

            var order = orders.FirstOrDefault(o => o.OrderID.ToString() == orderID);

            if (order != null)
            {
                order.Status = "Paid";

                SaveOrdersToFile("orders.txt", orders);
            }
            else
            {
                MessageBox.Show("Order not found.");
            }
        }
}
}
