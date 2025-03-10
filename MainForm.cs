using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Car_Rental_System
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            panelClient.Visible = false;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void UpdateOrderList()
        {
            listBoxOrders.Items.Clear();
            var orders = Order.LoadOrdersFromFile("orders.txt"); 

            foreach (var order in orders)
            {
                var item = new MaterialSkin.MaterialListBoxItem();

                item.Text = $"Order ID: {order.OrderID} | Car: {order.Car} | Status: {order.Status}";

                item.Tag = order;

                listBoxOrders.Items.Add(item);
            }
        }

        private void UpdateCarList()
        {
            listBoxCars.Items.Clear();
            listboxAdminCars.Items.Clear();
            var cars = Car.LoadCarsFromFile("cars.txt"); 

            foreach (var car in cars) 
            {
                var item = new MaterialSkin.MaterialListBoxItem();

                item.Text = $"{car.CarModel} | Status: {car.Status}";

                listBoxCars.Items.Add(item);
                listboxAdminCars.Items.Add(item);
            }
        }
        private void UpdateApprovedOrdersList()
        {
            var orders = Order.LoadOrdersFromFile("orders.txt");

            listBoxApprovedOrders.Items.Clear();

            var approvedOrders = orders.Where(o => o.Status == "Approved").ToList();

            foreach (var order in approvedOrders) 
            {
                var item = new MaterialSkin.MaterialListBoxItem();

                item.Text = $"OrderID: {order.OrderID} | Status: {order.Status} | Passport Details: {order.PassportDetails}";

                listBoxApprovedOrders.Items.Add(item);
            }

        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            panelClient.Visible = false;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            Client client = new Client();

            if (listBoxCars.SelectedItem != null)
            {
                var selectedItem = listBoxCars.SelectedItem as MaterialListBoxItem;

                if (selectedItem != null)
                {
                    string selectedCar = selectedItem.Text.Split('|')[0].Replace("Car: ", "").Trim();

                    var cars = Car.LoadCarsFromFile("cars.txt");

                    var car = cars.FirstOrDefault(c => c.CarModel == selectedCar);

                    if (car != null)
                    {
                        if (car.Status == "Damaged")
                        {
                            MessageBox.Show("This car is damaged and cannot be rented.");
                            return;
                        }

                        int rentalDays = int.TryParse(txtRentalDays.Text, out int days) ? days : 0;
                        string passportDetails = txtPassportDetails.Text;

                        if (!string.IsNullOrEmpty(selectedCar) && rentalDays > 0 && !string.IsNullOrEmpty(passportDetails))
                        {
                            client.RentCar(selectedCar, txtRentalDays, txtPassportDetails);
                        }
                        else
                        {
                            MessageBox.Show("Please select a car, specify rental days, and enter passport details.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected car not found.");
                    }
                }
            }
            txtPassportDetails.Clear();
            txtRentalDays.Clear();
        }

        private void btnClient_Click_1(object sender, EventArgs e)
        {
            panelClient.Visible = true;
            panelClient.BringToFront();
            UpdateCarList();
            UpdateApprovedOrdersList();
        }

        private void btnBackClient_Click(object sender, EventArgs e)
        {
            panelClient.Visible = false;
            panelAdmin.Visible = false;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (listBoxApprovedOrders.SelectedItem != null)
            {
                var selectedItem = listBoxApprovedOrders.SelectedItem as MaterialSkin.MaterialListBoxItem;

                if (selectedItem != null)
                {
                    string selectedOrder = selectedItem.Text;
                    MessageBox.Show("Selected Order: " + selectedOrder);

                    if (selectedOrder.Contains("OrderID:"))
                    {
                        string orderID = selectedOrder.Split('|')[0].Split(':')[1].Trim();

                        Order.CompletePayment(orderID);

                        UpdateOrderList();
                        MessageBox.Show("Payment completed.");
                    }
                    else
                    {
                        MessageBox.Show("Selected order is in an invalid format.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to cast the selected item.");
                }
            }
            else
            {
                MessageBox.Show("Please select an order to make payment.");
            }
        }

        private void btnBackAdmin_Click(object sender, EventArgs e)
        {
            panelAdmin.Visible = false;
            panelClient.Visible = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            panelAdmin.Visible = true;
            panelClient.Visible = false;
            UpdateOrderList();
            UpdateCarList();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (listBoxOrders.SelectedItem == null)
            {
                MessageBox.Show("Please select an order to approve.");
                return;
            }

            var selectedItem = listBoxOrders.SelectedItem as MaterialSkin.MaterialListBoxItem;

            if (selectedItem != null)
            {
                string selectedOrderText = selectedItem.Text;
                var parts = selectedOrderText.Split('|');

                if (parts.Length < 3)
                {
                    MessageBox.Show("Invalid order format.");
                    return;
                }

                string orderIDString = parts[0].Replace("Order ID:", "").Trim();
                string carModel = parts[1].Replace("Car:", "").Trim();
                string orderStatus = parts[2].Replace("Status:", "").Trim();

                if (string.IsNullOrEmpty(orderIDString) || !orderIDString.All(char.IsDigit))
                {
                    MessageBox.Show("Invalid OrderID format.");
                    return;
                }

                int orderID = int.Parse(orderIDString);

                var orders = Order.LoadOrdersFromFile("orders.txt");
                var order = orders.FirstOrDefault(o => o.OrderID == orderID);

                if (order != null)
                {
                    if (orderStatus == "Pending" || orderStatus == "Rejected")
                    {
                        order.Status = "Approved";
                        order.RejectionReason = "";

                        Order.SaveOrdersToFile("orders.txt", orders);

                        UpdateOrderList();

                        MessageBox.Show($"Order ID {orderID} has been approved.");
                    }
                    else
                    {
                        MessageBox.Show($"Order ID {orderID} is already approved or in an invalid state.");
                    }
                }
                else
                {
                    MessageBox.Show("Order not found.");
                }
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (listBoxOrders.SelectedItem == null)
            {
                MessageBox.Show("Please select an order to reject.");
                return;
            }

            var selectedItem = listBoxOrders.SelectedItem as MaterialSkin.MaterialListBoxItem;

            if (selectedItem == null)
            {
                MessageBox.Show("Invalid selection.");
                return;
            }

            var order = selectedItem.Tag as Order;

            if (order == null)
            {
                MessageBox.Show("Invalid order data.");
                return;
            }

            string rejectionReason = txtRejectionReason.Text.Trim();
            if (string.IsNullOrEmpty(rejectionReason))
            {
                MessageBox.Show("Please provide a reason for rejection.");
                return;
            }

            order.Status = "Rejected";
            order.RejectionReason = rejectionReason;

            var orders = Order.LoadOrdersFromFile("orders.txt");

            var orderToUpdate = orders.FirstOrDefault(o => o.OrderID == order.OrderID);
            if (orderToUpdate != null)
            {
                orderToUpdate.Status = "Rejected";
                orderToUpdate.RejectionReason = rejectionReason;
            }

            Order.SaveOrdersToFile("orders.txt", orders);

            UpdateOrderList();

            MessageBox.Show($"Order {order.OrderID} has been rejected. Reason: {rejectionReason}");
        }

            private void btnDamaged_Click(object sender, EventArgs e)
            {
            if (listboxAdminCars.SelectedItem == null)
            {
                MessageBox.Show("Please select a car to mark as damaged or available.");
                return;
            }

            var selectedItem = listboxAdminCars.SelectedItem as MaterialSkin.MaterialListBoxItem;
            if (selectedItem != null)
            {
                string selectedCar = selectedItem.Text.Split('|')[0].Replace("Car: ", "").Trim();

                var cars = Car.LoadCarsFromFile("cars.txt");

                var car = cars.FirstOrDefault(c => c.CarModel == selectedCar);

                if (car != null)
                {
                    if (car.Status == "Damaged")
                    {
                        car.Status = "Available";
                    }
                    else if (car.Status == "Available")
                    {
                        car.Status = "Damaged";
                    }

                    Car.SaveCarsToFile("cars.txt", cars);

                    UpdateCarList();
                    MessageBox.Show($"Car status updated to: {car.Status}");
                }
                else
                {
                    MessageBox.Show("Car not found.");
                }
            }
            else
            {
                MessageBox.Show("Failed to cast the selected item.");
            }
        }
    }
}
