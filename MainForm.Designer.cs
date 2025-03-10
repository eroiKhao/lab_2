namespace Car_Rental_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClient = new MaterialSkin.Controls.MaterialButton();
            this.btnAdmin = new MaterialSkin.Controls.MaterialButton();
            this.panelClient = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.carslabel = new MaterialSkin.Controls.MaterialLabel();
            this.btnPayment = new MaterialSkin.Controls.MaterialButton();
            this.listBoxApprovedOrders = new MaterialSkin.Controls.MaterialListBox();
            this.txtPassportDetails = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBackClient = new MaterialSkin.Controls.MaterialButton();
            this.btnRent = new MaterialSkin.Controls.MaterialButton();
            this.txtRentalDays = new MaterialSkin.Controls.MaterialTextBox();
            this.listBoxCars = new MaterialSkin.Controls.MaterialListBox();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.listboxAdminCars = new MaterialSkin.Controls.MaterialListBox();
            this.txtRejectionReason = new MaterialSkin.Controls.MaterialTextBox();
            this.btnDamaged = new MaterialSkin.Controls.MaterialButton();
            this.btnReject = new MaterialSkin.Controls.MaterialButton();
            this.btnApprove = new MaterialSkin.Controls.MaterialButton();
            this.btnBackAdmin = new MaterialSkin.Controls.MaterialButton();
            this.listBoxOrders = new MaterialSkin.Controls.MaterialListBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.panelClient.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClient.Depth = 0;
            this.btnClient.HighEmphasis = true;
            this.btnClient.Icon = null;
            this.btnClient.Location = new System.Drawing.Point(491, 343);
            this.btnClient.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClient.Name = "btnClient";
            this.btnClient.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClient.Size = new System.Drawing.Size(71, 36);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Client";
            this.btnClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClient.UseAccentColor = false;
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click_1);
            // 
            // btnAdmin
            // 
            this.btnAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdmin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdmin.Depth = 0;
            this.btnAdmin.HighEmphasis = true;
            this.btnAdmin.Icon = null;
            this.btnAdmin.Location = new System.Drawing.Point(670, 343);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdmin.Size = new System.Drawing.Size(68, 36);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdmin.UseAccentColor = false;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.materialLabel2);
            this.panelClient.Controls.Add(this.carslabel);
            this.panelClient.Controls.Add(this.btnPayment);
            this.panelClient.Controls.Add(this.listBoxApprovedOrders);
            this.panelClient.Controls.Add(this.txtPassportDetails);
            this.panelClient.Controls.Add(this.btnBackClient);
            this.panelClient.Controls.Add(this.btnRent);
            this.panelClient.Controls.Add(this.txtRentalDays);
            this.panelClient.Controls.Add(this.listBoxCars);
            this.panelClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClient.Location = new System.Drawing.Point(3, 64);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(1222, 486);
            this.panelClient.TabIndex = 2;
            this.panelClient.Visible = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(959, 30);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(64, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Payment";
            // 
            // carslabel
            // 
            this.carslabel.AutoSize = true;
            this.carslabel.Depth = 0;
            this.carslabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.carslabel.Location = new System.Drawing.Point(462, 30);
            this.carslabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.carslabel.Name = "carslabel";
            this.carslabel.Size = new System.Drawing.Size(33, 19);
            this.carslabel.TabIndex = 7;
            this.carslabel.Text = "Cars";
            // 
            // btnPayment
            // 
            this.btnPayment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPayment.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPayment.Depth = 0;
            this.btnPayment.HighEmphasis = true;
            this.btnPayment.Icon = null;
            this.btnPayment.Location = new System.Drawing.Point(936, 419);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPayment.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPayment.Size = new System.Drawing.Size(134, 36);
            this.btnPayment.TabIndex = 6;
            this.btnPayment.Text = "Make Payment";
            this.btnPayment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPayment.UseAccentColor = false;
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // listBoxApprovedOrders
            // 
            this.listBoxApprovedOrders.BackColor = System.Drawing.Color.White;
            this.listBoxApprovedOrders.BorderColor = System.Drawing.Color.LightGray;
            this.listBoxApprovedOrders.Depth = 0;
            this.listBoxApprovedOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listBoxApprovedOrders.Location = new System.Drawing.Point(732, 69);
            this.listBoxApprovedOrders.MouseState = MaterialSkin.MouseState.HOVER;
            this.listBoxApprovedOrders.Name = "listBoxApprovedOrders";
            this.listBoxApprovedOrders.SelectedIndex = -1;
            this.listBoxApprovedOrders.SelectedItem = null;
            this.listBoxApprovedOrders.Size = new System.Drawing.Size(487, 330);
            this.listBoxApprovedOrders.TabIndex = 5;
            // 
            // txtPassportDetails
            // 
            this.txtPassportDetails.AnimateReadOnly = false;
            this.txtPassportDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassportDetails.Depth = 0;
            this.txtPassportDetails.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassportDetails.Hint = "Passport details";
            this.txtPassportDetails.LeadingIcon = null;
            this.txtPassportDetails.Location = new System.Drawing.Point(20, 109);
            this.txtPassportDetails.MaxLength = 50;
            this.txtPassportDetails.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassportDetails.Multiline = false;
            this.txtPassportDetails.Name = "txtPassportDetails";
            this.txtPassportDetails.Size = new System.Drawing.Size(198, 50);
            this.txtPassportDetails.TabIndex = 4;
            this.txtPassportDetails.Text = "";
            this.txtPassportDetails.TrailingIcon = null;
            // 
            // btnBackClient
            // 
            this.btnBackClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBackClient.Depth = 0;
            this.btnBackClient.HighEmphasis = true;
            this.btnBackClient.Icon = null;
            this.btnBackClient.Location = new System.Drawing.Point(57, 399);
            this.btnBackClient.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBackClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackClient.Name = "btnBackClient";
            this.btnBackClient.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBackClient.Size = new System.Drawing.Size(64, 36);
            this.btnBackClient.TabIndex = 3;
            this.btnBackClient.Text = "Back";
            this.btnBackClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBackClient.UseAccentColor = false;
            this.btnBackClient.UseVisualStyleBackColor = true;
            this.btnBackClient.Click += new System.EventHandler(this.btnBackClient_Click);
            // 
            // btnRent
            // 
            this.btnRent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRent.Depth = 0;
            this.btnRent.HighEmphasis = true;
            this.btnRent.Icon = null;
            this.btnRent.Location = new System.Drawing.Point(120, 252);
            this.btnRent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRent.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRent.Name = "btnRent";
            this.btnRent.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRent.Size = new System.Drawing.Size(64, 36);
            this.btnRent.TabIndex = 2;
            this.btnRent.Text = "Rent";
            this.btnRent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRent.UseAccentColor = false;
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // txtRentalDays
            // 
            this.txtRentalDays.AnimateReadOnly = false;
            this.txtRentalDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRentalDays.Depth = 0;
            this.txtRentalDays.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRentalDays.Hint = "Rental period";
            this.txtRentalDays.LeadingIcon = null;
            this.txtRentalDays.Location = new System.Drawing.Point(20, 178);
            this.txtRentalDays.MaxLength = 50;
            this.txtRentalDays.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRentalDays.Multiline = false;
            this.txtRentalDays.Name = "txtRentalDays";
            this.txtRentalDays.Size = new System.Drawing.Size(198, 50);
            this.txtRentalDays.TabIndex = 1;
            this.txtRentalDays.Text = "";
            this.txtRentalDays.TrailingIcon = null;
            // 
            // listBoxCars
            // 
            this.listBoxCars.BackColor = System.Drawing.Color.White;
            this.listBoxCars.BorderColor = System.Drawing.Color.LightGray;
            this.listBoxCars.Depth = 0;
            this.listBoxCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listBoxCars.Location = new System.Drawing.Point(224, 52);
            this.listBoxCars.MouseState = MaterialSkin.MouseState.HOVER;
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.SelectedIndex = -1;
            this.listBoxCars.SelectedItem = null;
            this.listBoxCars.Size = new System.Drawing.Size(492, 403);
            this.listBoxCars.TabIndex = 0;
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.listboxAdminCars);
            this.panelAdmin.Controls.Add(this.txtRejectionReason);
            this.panelAdmin.Controls.Add(this.btnDamaged);
            this.panelAdmin.Controls.Add(this.btnReject);
            this.panelAdmin.Controls.Add(this.btnApprove);
            this.panelAdmin.Controls.Add(this.btnBackAdmin);
            this.panelAdmin.Controls.Add(this.listBoxOrders);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdmin.Location = new System.Drawing.Point(3, 64);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(1222, 486);
            this.panelAdmin.TabIndex = 9;
            this.panelAdmin.Visible = false;
            // 
            // listboxAdminCars
            // 
            this.listboxAdminCars.BackColor = System.Drawing.Color.White;
            this.listboxAdminCars.BorderColor = System.Drawing.Color.LightGray;
            this.listboxAdminCars.Depth = 0;
            this.listboxAdminCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listboxAdminCars.Location = new System.Drawing.Point(684, 30);
            this.listboxAdminCars.MouseState = MaterialSkin.MouseState.HOVER;
            this.listboxAdminCars.Name = "listboxAdminCars";
            this.listboxAdminCars.SelectedIndex = -1;
            this.listboxAdminCars.SelectedItem = null;
            this.listboxAdminCars.Size = new System.Drawing.Size(535, 245);
            this.listboxAdminCars.TabIndex = 6;
            // 
            // txtRejectionReason
            // 
            this.txtRejectionReason.AnimateReadOnly = false;
            this.txtRejectionReason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRejectionReason.Depth = 0;
            this.txtRejectionReason.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRejectionReason.Hint = "Rejection reason";
            this.txtRejectionReason.LeadingIcon = null;
            this.txtRejectionReason.Location = new System.Drawing.Point(307, 325);
            this.txtRejectionReason.MaxLength = 50;
            this.txtRejectionReason.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRejectionReason.Multiline = false;
            this.txtRejectionReason.Name = "txtRejectionReason";
            this.txtRejectionReason.Size = new System.Drawing.Size(287, 50);
            this.txtRejectionReason.TabIndex = 5;
            this.txtRejectionReason.Text = "";
            this.txtRejectionReason.TrailingIcon = null;
            // 
            // btnDamaged
            // 
            this.btnDamaged.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDamaged.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDamaged.Depth = 0;
            this.btnDamaged.HighEmphasis = true;
            this.btnDamaged.Icon = null;
            this.btnDamaged.Location = new System.Drawing.Point(1007, 297);
            this.btnDamaged.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDamaged.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDamaged.Name = "btnDamaged";
            this.btnDamaged.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDamaged.Size = new System.Drawing.Size(158, 36);
            this.btnDamaged.TabIndex = 4;
            this.btnDamaged.Text = "Mark as Damaged";
            this.btnDamaged.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDamaged.UseAccentColor = false;
            this.btnDamaged.UseVisualStyleBackColor = true;
            this.btnDamaged.Click += new System.EventHandler(this.btnDamaged_Click);
            // 
            // btnReject
            // 
            this.btnReject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReject.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReject.Depth = 0;
            this.btnReject.HighEmphasis = true;
            this.btnReject.Icon = null;
            this.btnReject.Location = new System.Drawing.Point(476, 399);
            this.btnReject.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReject.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReject.Name = "btnReject";
            this.btnReject.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReject.Size = new System.Drawing.Size(74, 36);
            this.btnReject.TabIndex = 3;
            this.btnReject.Text = "Reject";
            this.btnReject.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReject.UseAccentColor = false;
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApprove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnApprove.Depth = 0;
            this.btnApprove.HighEmphasis = true;
            this.btnApprove.Icon = null;
            this.btnApprove.Location = new System.Drawing.Point(318, 399);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnApprove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnApprove.Size = new System.Drawing.Size(87, 36);
            this.btnApprove.TabIndex = 2;
            this.btnApprove.Text = "Approve";
            this.btnApprove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnApprove.UseAccentColor = false;
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnBackAdmin
            // 
            this.btnBackAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackAdmin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBackAdmin.Depth = 0;
            this.btnBackAdmin.HighEmphasis = true;
            this.btnBackAdmin.Icon = null;
            this.btnBackAdmin.Location = new System.Drawing.Point(37, 411);
            this.btnBackAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBackAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackAdmin.Name = "btnBackAdmin";
            this.btnBackAdmin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBackAdmin.Size = new System.Drawing.Size(64, 36);
            this.btnBackAdmin.TabIndex = 1;
            this.btnBackAdmin.Text = "Back";
            this.btnBackAdmin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBackAdmin.UseAccentColor = false;
            this.btnBackAdmin.UseVisualStyleBackColor = true;
            this.btnBackAdmin.Click += new System.EventHandler(this.btnBackAdmin_Click);
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.BackColor = System.Drawing.Color.White;
            this.listBoxOrders.BorderColor = System.Drawing.Color.LightGray;
            this.listBoxOrders.Depth = 0;
            this.listBoxOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listBoxOrders.Location = new System.Drawing.Point(22, 16);
            this.listBoxOrders.MouseState = MaterialSkin.MouseState.HOVER;
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.SelectedIndex = -1;
            this.listBoxOrders.SelectedItem = null;
            this.listBoxOrders.Size = new System.Drawing.Size(656, 303);
            this.listBoxOrders.TabIndex = 0;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(545, 191);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(123, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Choose your role:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 553);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.panelClient);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.materialLabel3);
            this.Name = "MainForm";
            this.Text = "Car Rental System";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnClient;
        private MaterialSkin.Controls.MaterialButton btnAdmin;
        private System.Windows.Forms.Panel panelClient;
        private MaterialSkin.Controls.MaterialListBox listBoxCars;
        private MaterialSkin.Controls.MaterialButton btnBackClient;
        private MaterialSkin.Controls.MaterialButton btnRent;
        private MaterialSkin.Controls.MaterialTextBox txtRentalDays;
        private MaterialSkin.Controls.MaterialTextBox txtPassportDetails;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel carslabel;
        private MaterialSkin.Controls.MaterialButton btnPayment;
        private MaterialSkin.Controls.MaterialListBox listBoxApprovedOrders;
        private System.Windows.Forms.Panel panelAdmin;
        private MaterialSkin.Controls.MaterialButton btnDamaged;
        private MaterialSkin.Controls.MaterialButton btnReject;
        private MaterialSkin.Controls.MaterialButton btnApprove;
        private MaterialSkin.Controls.MaterialButton btnBackAdmin;
        private MaterialSkin.Controls.MaterialListBox listBoxOrders;
        private MaterialSkin.Controls.MaterialTextBox txtRejectionReason;
        private MaterialSkin.Controls.MaterialListBox listboxAdminCars;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}

