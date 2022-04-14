
namespace Project
{
    partial class Form1
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddFlight = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewAllFlights = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewASpecificFlight = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteFlight = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewAllBookings = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerPanel = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.lblAddCustomerOutput = new System.Windows.Forms.Label();
            this.btnRegisterCustomer = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.viewASpecificFlightPanel = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.lblViewSpecificFlightOutput = new System.Windows.Forms.Label();
            this.btnActualViewSpecificFlight = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFlightNumberView = new System.Windows.Forms.TextBox();
            this.deleteCustomerPanel = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.lblDeleteCustomerOutput = new System.Windows.Forms.Label();
            this.btnDeleteCust = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustomerIdDelete = new System.Windows.Forms.TextBox();
            this.deleteFlightPanel = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.lblDeleteFlightOutput = new System.Windows.Forms.Label();
            this.btnActualDeleteFlight = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFlightNumberDelete = new System.Windows.Forms.TextBox();
            this.addFlightPanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtMaxSeats = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAddFlightOutput = new System.Windows.Forms.Label();
            this.btnActualAddFlight = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.addBookingPanel = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.txtFlightNumberBooking = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAddBookingOuput = new System.Windows.Forms.Label();
            this.btnActualAddBooking = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCustomerIdBooking = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.lblWelcomeOutput = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMaxNumBooking = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtMaxNumCust = new System.Windows.Forms.TextBox();
            this.txtMaxNumFlight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.alternateWelcomePanel = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.addCustomerPanel.SuspendLayout();
            this.viewASpecificFlightPanel.SuspendLayout();
            this.deleteCustomerPanel.SuspendLayout();
            this.deleteFlightPanel.SuspendLayout();
            this.addFlightPanel.SuspendLayout();
            this.addBookingPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.welcomePanel.SuspendLayout();
            this.alternateWelcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.LightCyan;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.btnAddFlight,
            this.bookingToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1649, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            this.mainMenu.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 26);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 26);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCustomer,
            this.btnViewCustomers,
            this.btnDeleteCustomer});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(146, 26);
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(146, 26);
            this.btnViewCustomers.Text = "View All";
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(146, 26);
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.btnViewAllFlights,
            this.btnViewASpecificFlight,
            this.btnDeleteFlight});
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(60, 24);
            this.btnAddFlight.Text = "Flight";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // btnViewAllFlights
            // 
            this.btnViewAllFlights.Name = "btnViewAllFlights";
            this.btnViewAllFlights.Size = new System.Drawing.Size(235, 26);
            this.btnViewAllFlights.Text = "View All";
            this.btnViewAllFlights.Click += new System.EventHandler(this.btnViewAllFlights_Click);
            // 
            // btnViewASpecificFlight
            // 
            this.btnViewASpecificFlight.Name = "btnViewASpecificFlight";
            this.btnViewASpecificFlight.Size = new System.Drawing.Size(235, 26);
            this.btnViewASpecificFlight.Text = "View A Specific Flight";
            this.btnViewASpecificFlight.Click += new System.EventHandler(this.btnViewASpecificFlight_Click);
            // 
            // btnDeleteFlight
            // 
            this.btnDeleteFlight.Name = "btnDeleteFlight";
            this.btnDeleteFlight.Size = new System.Drawing.Size(235, 26);
            this.btnDeleteFlight.Text = "Delete";
            this.btnDeleteFlight.Click += new System.EventHandler(this.btnDeleteFlight_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddBooking,
            this.btnViewAllBookings});
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(146, 26);
            this.btnAddBooking.Text = "Add";
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // btnViewAllBookings
            // 
            this.btnViewAllBookings.Name = "btnViewAllBookings";
            this.btnViewAllBookings.Size = new System.Drawing.Size(146, 26);
            this.btnViewAllBookings.Text = "View All";
            this.btnViewAllBookings.Click += new System.EventHandler(this.btnViewAllBookings_Click);
            // 
            // addCustomerPanel
            // 
            this.addCustomerPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.addCustomerPanel.Controls.Add(this.label22);
            this.addCustomerPanel.Controls.Add(this.lblAddCustomerOutput);
            this.addCustomerPanel.Controls.Add(this.btnRegisterCustomer);
            this.addCustomerPanel.Controls.Add(this.txtPhone);
            this.addCustomerPanel.Controls.Add(this.txtLastName);
            this.addCustomerPanel.Controls.Add(this.label3);
            this.addCustomerPanel.Controls.Add(this.label2);
            this.addCustomerPanel.Controls.Add(this.label1);
            this.addCustomerPanel.Controls.Add(this.txtFirstName);
            this.addCustomerPanel.Location = new System.Drawing.Point(12, 167);
            this.addCustomerPanel.Name = "addCustomerPanel";
            this.addCustomerPanel.Size = new System.Drawing.Size(556, 469);
            this.addCustomerPanel.TabIndex = 2;
            this.addCustomerPanel.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(210, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(166, 29);
            this.label22.TabIndex = 15;
            this.label22.Text = "Add Customer";
            // 
            // lblAddCustomerOutput
            // 
            this.lblAddCustomerOutput.AutoSize = true;
            this.lblAddCustomerOutput.Location = new System.Drawing.Point(75, 322);
            this.lblAddCustomerOutput.MinimumSize = new System.Drawing.Size(400, 0);
            this.lblAddCustomerOutput.Name = "lblAddCustomerOutput";
            this.lblAddCustomerOutput.Size = new System.Drawing.Size(400, 17);
            this.lblAddCustomerOutput.TabIndex = 7;
            // 
            // btnRegisterCustomer
            // 
            this.btnRegisterCustomer.Location = new System.Drawing.Point(215, 239);
            this.btnRegisterCustomer.Name = "btnRegisterCustomer";
            this.btnRegisterCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterCustomer.TabIndex = 6;
            this.btnRegisterCustomer.Text = "Add";
            this.btnRegisterCustomer.UseVisualStyleBackColor = true;
            this.btnRegisterCustomer.Click += new System.EventHandler(this.btnRegisterCustomer_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(215, 181);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(242, 22);
            this.txtPhone.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(215, 122);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(242, 22);
            this.txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(215, 69);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(242, 22);
            this.txtFirstName.TabIndex = 0;
            // 
            // viewASpecificFlightPanel
            // 
            this.viewASpecificFlightPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.viewASpecificFlightPanel.Controls.Add(this.label20);
            this.viewASpecificFlightPanel.Controls.Add(this.lblViewSpecificFlightOutput);
            this.viewASpecificFlightPanel.Controls.Add(this.btnActualViewSpecificFlight);
            this.viewASpecificFlightPanel.Controls.Add(this.label13);
            this.viewASpecificFlightPanel.Controls.Add(this.txtFlightNumberView);
            this.viewASpecificFlightPanel.Location = new System.Drawing.Point(37, 37);
            this.viewASpecificFlightPanel.Name = "viewASpecificFlightPanel";
            this.viewASpecificFlightPanel.Size = new System.Drawing.Size(556, 469);
            this.viewASpecificFlightPanel.TabIndex = 5;
            this.viewASpecificFlightPanel.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(223, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(132, 29);
            this.label20.TabIndex = 15;
            this.label20.Text = "View Flight";
            // 
            // lblViewSpecificFlightOutput
            // 
            this.lblViewSpecificFlightOutput.AutoSize = true;
            this.lblViewSpecificFlightOutput.Location = new System.Drawing.Point(50, 174);
            this.lblViewSpecificFlightOutput.MinimumSize = new System.Drawing.Size(400, 0);
            this.lblViewSpecificFlightOutput.Name = "lblViewSpecificFlightOutput";
            this.lblViewSpecificFlightOutput.Size = new System.Drawing.Size(400, 17);
            this.lblViewSpecificFlightOutput.TabIndex = 7;
            // 
            // btnActualViewSpecificFlight
            // 
            this.btnActualViewSpecificFlight.Location = new System.Drawing.Point(228, 117);
            this.btnActualViewSpecificFlight.Name = "btnActualViewSpecificFlight";
            this.btnActualViewSpecificFlight.Size = new System.Drawing.Size(75, 23);
            this.btnActualViewSpecificFlight.TabIndex = 6;
            this.btnActualViewSpecificFlight.Text = "View";
            this.btnActualViewSpecificFlight.UseVisualStyleBackColor = true;
            this.btnActualViewSpecificFlight.Click += new System.EventHandler(this.btnActualViewSpecificFlight_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Flight Number";
            // 
            // txtFlightNumberView
            // 
            this.txtFlightNumberView.Location = new System.Drawing.Point(228, 61);
            this.txtFlightNumberView.Name = "txtFlightNumberView";
            this.txtFlightNumberView.Size = new System.Drawing.Size(242, 22);
            this.txtFlightNumberView.TabIndex = 0;
            // 
            // deleteCustomerPanel
            // 
            this.deleteCustomerPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.deleteCustomerPanel.Controls.Add(this.label21);
            this.deleteCustomerPanel.Controls.Add(this.lblDeleteCustomerOutput);
            this.deleteCustomerPanel.Controls.Add(this.btnDeleteCust);
            this.deleteCustomerPanel.Controls.Add(this.label7);
            this.deleteCustomerPanel.Controls.Add(this.txtCustomerIdDelete);
            this.deleteCustomerPanel.Location = new System.Drawing.Point(50, 17);
            this.deleteCustomerPanel.Name = "deleteCustomerPanel";
            this.deleteCustomerPanel.Size = new System.Drawing.Size(556, 469);
            this.deleteCustomerPanel.TabIndex = 3;
            this.deleteCustomerPanel.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(219, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(194, 29);
            this.label21.TabIndex = 15;
            this.label21.Text = "Delete Customer";
            // 
            // lblDeleteCustomerOutput
            // 
            this.lblDeleteCustomerOutput.AutoSize = true;
            this.lblDeleteCustomerOutput.Location = new System.Drawing.Point(84, 182);
            this.lblDeleteCustomerOutput.MinimumSize = new System.Drawing.Size(400, 0);
            this.lblDeleteCustomerOutput.Name = "lblDeleteCustomerOutput";
            this.lblDeleteCustomerOutput.Size = new System.Drawing.Size(400, 17);
            this.lblDeleteCustomerOutput.TabIndex = 7;
            // 
            // btnDeleteCust
            // 
            this.btnDeleteCust.Location = new System.Drawing.Point(224, 117);
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCust.TabIndex = 6;
            this.btnDeleteCust.Text = "Delete";
            this.btnDeleteCust.UseVisualStyleBackColor = true;
            this.btnDeleteCust.Click += new System.EventHandler(this.btnDeleteCust_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Customer Id";
            // 
            // txtCustomerIdDelete
            // 
            this.txtCustomerIdDelete.Location = new System.Drawing.Point(224, 65);
            this.txtCustomerIdDelete.Name = "txtCustomerIdDelete";
            this.txtCustomerIdDelete.Size = new System.Drawing.Size(242, 22);
            this.txtCustomerIdDelete.TabIndex = 0;
            // 
            // deleteFlightPanel
            // 
            this.deleteFlightPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.deleteFlightPanel.Controls.Add(this.label19);
            this.deleteFlightPanel.Controls.Add(this.lblDeleteFlightOutput);
            this.deleteFlightPanel.Controls.Add(this.btnActualDeleteFlight);
            this.deleteFlightPanel.Controls.Add(this.label10);
            this.deleteFlightPanel.Controls.Add(this.txtFlightNumberDelete);
            this.deleteFlightPanel.Location = new System.Drawing.Point(37, 69);
            this.deleteFlightPanel.Name = "deleteFlightPanel";
            this.deleteFlightPanel.Size = new System.Drawing.Size(556, 469);
            this.deleteFlightPanel.TabIndex = 8;
            this.deleteFlightPanel.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(229, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(144, 29);
            this.label19.TabIndex = 15;
            this.label19.Text = "DeleteFlight";
            // 
            // lblDeleteFlightOutput
            // 
            this.lblDeleteFlightOutput.AutoSize = true;
            this.lblDeleteFlightOutput.Location = new System.Drawing.Point(67, 196);
            this.lblDeleteFlightOutput.MinimumSize = new System.Drawing.Size(400, 0);
            this.lblDeleteFlightOutput.Name = "lblDeleteFlightOutput";
            this.lblDeleteFlightOutput.Size = new System.Drawing.Size(400, 17);
            this.lblDeleteFlightOutput.TabIndex = 7;
            // 
            // btnActualDeleteFlight
            // 
            this.btnActualDeleteFlight.Location = new System.Drawing.Point(234, 127);
            this.btnActualDeleteFlight.Name = "btnActualDeleteFlight";
            this.btnActualDeleteFlight.Size = new System.Drawing.Size(75, 23);
            this.btnActualDeleteFlight.TabIndex = 6;
            this.btnActualDeleteFlight.Text = "Delete";
            this.btnActualDeleteFlight.UseVisualStyleBackColor = true;
            this.btnActualDeleteFlight.Click += new System.EventHandler(this.btnActualDeleteFlight_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Flight Number";
            // 
            // txtFlightNumberDelete
            // 
            this.txtFlightNumberDelete.Location = new System.Drawing.Point(234, 71);
            this.txtFlightNumberDelete.Name = "txtFlightNumberDelete";
            this.txtFlightNumberDelete.Size = new System.Drawing.Size(242, 22);
            this.txtFlightNumberDelete.TabIndex = 0;
            // 
            // addFlightPanel
            // 
            this.addFlightPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.addFlightPanel.Controls.Add(this.label17);
            this.addFlightPanel.Controls.Add(this.txtOrigin);
            this.addFlightPanel.Controls.Add(this.txtDestination);
            this.addFlightPanel.Controls.Add(this.txtMaxSeats);
            this.addFlightPanel.Controls.Add(this.label9);
            this.addFlightPanel.Controls.Add(this.label8);
            this.addFlightPanel.Controls.Add(this.label6);
            this.addFlightPanel.Controls.Add(this.lblAddFlightOutput);
            this.addFlightPanel.Controls.Add(this.btnActualAddFlight);
            this.addFlightPanel.Controls.Add(this.label5);
            this.addFlightPanel.Controls.Add(this.txtFlightNumber);
            this.addFlightPanel.Location = new System.Drawing.Point(12, 142);
            this.addFlightPanel.Name = "addFlightPanel";
            this.addFlightPanel.Size = new System.Drawing.Size(556, 469);
            this.addFlightPanel.TabIndex = 4;
            this.addFlightPanel.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(245, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 29);
            this.label17.TabIndex = 14;
            this.label17.Text = "Add Flight";
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(250, 116);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(242, 22);
            this.txtOrigin.TabIndex = 13;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(250, 172);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(242, 22);
            this.txtDestination.TabIndex = 12;
            // 
            // txtMaxSeats
            // 
            this.txtMaxSeats.Location = new System.Drawing.Point(250, 233);
            this.txtMaxSeats.Name = "txtMaxSeats";
            this.txtMaxSeats.Size = new System.Drawing.Size(242, 22);
            this.txtMaxSeats.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Origin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Max number of seats";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Destination";
            // 
            // lblAddFlightOutput
            // 
            this.lblAddFlightOutput.AutoSize = true;
            this.lblAddFlightOutput.Location = new System.Drawing.Point(72, 362);
            this.lblAddFlightOutput.MinimumSize = new System.Drawing.Size(400, 0);
            this.lblAddFlightOutput.Name = "lblAddFlightOutput";
            this.lblAddFlightOutput.Size = new System.Drawing.Size(400, 17);
            this.lblAddFlightOutput.TabIndex = 7;
            // 
            // btnActualAddFlight
            // 
            this.btnActualAddFlight.Location = new System.Drawing.Point(250, 292);
            this.btnActualAddFlight.Name = "btnActualAddFlight";
            this.btnActualAddFlight.Size = new System.Drawing.Size(75, 23);
            this.btnActualAddFlight.TabIndex = 6;
            this.btnActualAddFlight.Text = "Add Flight";
            this.btnActualAddFlight.UseVisualStyleBackColor = true;
            this.btnActualAddFlight.Click += new System.EventHandler(this.btnActualAddFlight_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Flight Number";
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Location = new System.Drawing.Point(250, 63);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(242, 22);
            this.txtFlightNumber.TabIndex = 0;
            // 
            // addBookingPanel
            // 
            this.addBookingPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.addBookingPanel.Controls.Add(this.label18);
            this.addBookingPanel.Controls.Add(this.txtFlightNumberBooking);
            this.addBookingPanel.Controls.Add(this.label12);
            this.addBookingPanel.Controls.Add(this.lblAddBookingOuput);
            this.addBookingPanel.Controls.Add(this.btnActualAddBooking);
            this.addBookingPanel.Controls.Add(this.label11);
            this.addBookingPanel.Controls.Add(this.txtCustomerIdBooking);
            this.addBookingPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addBookingPanel.Location = new System.Drawing.Point(12, 67);
            this.addBookingPanel.Name = "addBookingPanel";
            this.addBookingPanel.Size = new System.Drawing.Size(520, 467);
            this.addBookingPanel.TabIndex = 9;
            this.addBookingPanel.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(235, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(151, 29);
            this.label18.TabIndex = 15;
            this.label18.Text = "Add Booking";
            // 
            // txtFlightNumberBooking
            // 
            this.txtFlightNumberBooking.Location = new System.Drawing.Point(240, 130);
            this.txtFlightNumberBooking.Name = "txtFlightNumberBooking";
            this.txtFlightNumberBooking.Size = new System.Drawing.Size(242, 22);
            this.txtFlightNumberBooking.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Flight Number";
            // 
            // lblAddBookingOuput
            // 
            this.lblAddBookingOuput.AutoSize = true;
            this.lblAddBookingOuput.Location = new System.Drawing.Point(67, 237);
            this.lblAddBookingOuput.MinimumSize = new System.Drawing.Size(400, 0);
            this.lblAddBookingOuput.Name = "lblAddBookingOuput";
            this.lblAddBookingOuput.Size = new System.Drawing.Size(400, 17);
            this.lblAddBookingOuput.TabIndex = 7;
            // 
            // btnActualAddBooking
            // 
            this.btnActualAddBooking.Location = new System.Drawing.Point(240, 182);
            this.btnActualAddBooking.Name = "btnActualAddBooking";
            this.btnActualAddBooking.Size = new System.Drawing.Size(75, 23);
            this.btnActualAddBooking.TabIndex = 6;
            this.btnActualAddBooking.Text = "Add";
            this.btnActualAddBooking.UseVisualStyleBackColor = true;
            this.btnActualAddBooking.Click += new System.EventHandler(this.btnActualAddBooking_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(67, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Customer Id";
            // 
            // txtCustomerIdBooking
            // 
            this.txtCustomerIdBooking.Location = new System.Drawing.Point(240, 71);
            this.txtCustomerIdBooking.Name = "txtCustomerIdBooking";
            this.txtCustomerIdBooking.Size = new System.Drawing.Size(242, 22);
            this.txtCustomerIdBooking.TabIndex = 0;
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.outputBox.DetectUrls = false;
            this.outputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(20, 20);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(801, 629);
            this.outputBox.TabIndex = 10;
            this.outputBox.Text = "";
            this.outputBox.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.outputBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(808, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(841, 669);
            this.panel1.TabIndex = 11;
            // 
            // welcomePanel
            // 
            this.welcomePanel.Controls.Add(this.lblWelcomeOutput);
            this.welcomePanel.Controls.Add(this.label16);
            this.welcomePanel.Controls.Add(this.txtMaxNumBooking);
            this.welcomePanel.Controls.Add(this.label15);
            this.welcomePanel.Controls.Add(this.btnSubmit);
            this.welcomePanel.Controls.Add(this.txtMaxNumCust);
            this.welcomePanel.Controls.Add(this.txtMaxNumFlight);
            this.welcomePanel.Controls.Add(this.label4);
            this.welcomePanel.Controls.Add(this.label14);
            this.welcomePanel.Controls.Add(this.lblHeading);
            this.welcomePanel.Location = new System.Drawing.Point(18, 20);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(572, 299);
            this.welcomePanel.TabIndex = 12;
            this.welcomePanel.Visible = false;
            // 
            // lblWelcomeOutput
            // 
            this.lblWelcomeOutput.AutoSize = true;
            this.lblWelcomeOutput.Location = new System.Drawing.Point(241, 260);
            this.lblWelcomeOutput.Name = "lblWelcomeOutput";
            this.lblWelcomeOutput.Size = new System.Drawing.Size(0, 17);
            this.lblWelcomeOutput.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(108, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(335, 17);
            this.label16.TabIndex = 19;
            this.label16.Text = "Please Enter The Following Information To Continue";
            // 
            // txtMaxNumBooking
            // 
            this.txtMaxNumBooking.Location = new System.Drawing.Point(244, 182);
            this.txtMaxNumBooking.Name = "txtMaxNumBooking";
            this.txtMaxNumBooking.Size = new System.Drawing.Size(242, 22);
            this.txtMaxNumBooking.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(42, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(165, 17);
            this.label15.TabIndex = 17;
            this.label15.Text = "Max Number of Bookings";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(244, 221);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtMaxNumCust
            // 
            this.txtMaxNumCust.Location = new System.Drawing.Point(244, 134);
            this.txtMaxNumCust.Name = "txtMaxNumCust";
            this.txtMaxNumCust.Size = new System.Drawing.Size(242, 22);
            this.txtMaxNumCust.TabIndex = 15;
            // 
            // txtMaxNumFlight
            // 
            this.txtMaxNumFlight.Location = new System.Drawing.Point(244, 86);
            this.txtMaxNumFlight.Name = "txtMaxNumFlight";
            this.txtMaxNumFlight.Size = new System.Drawing.Size(242, 22);
            this.txtMaxNumFlight.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Max Number of Customers";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 17);
            this.label14.TabIndex = 11;
            this.label14.Text = "Max Number of Flights";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(139, 5);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(269, 29);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Welcome to ABC Airline";
            // 
            // alternateWelcomePanel
            // 
            this.alternateWelcomePanel.Controls.Add(this.label24);
            this.alternateWelcomePanel.Controls.Add(this.label28);
            this.alternateWelcomePanel.Location = new System.Drawing.Point(18, 110);
            this.alternateWelcomePanel.Name = "alternateWelcomePanel";
            this.alternateWelcomePanel.Size = new System.Drawing.Size(572, 299);
            this.alternateWelcomePanel.TabIndex = 13;
            this.alternateWelcomePanel.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(114, 42);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(343, 17);
            this.label24.TabIndex = 19;
            this.label24.Text = "Select operations in the top left corner menu to begin";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(139, 5);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(269, 29);
            this.label28.TabIndex = 0;
            this.label28.Text = "Welcome to ABC Airline";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1649, 669);
            this.Controls.Add(this.alternateWelcomePanel);
            this.Controls.Add(this.welcomePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addFlightPanel);
            this.Controls.Add(this.addBookingPanel);
            this.Controls.Add(this.deleteFlightPanel);
            this.Controls.Add(this.viewASpecificFlightPanel);
            this.Controls.Add(this.deleteCustomerPanel);
            this.Controls.Add(this.addCustomerPanel);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "Flight Reservation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.addCustomerPanel.ResumeLayout(false);
            this.addCustomerPanel.PerformLayout();
            this.viewASpecificFlightPanel.ResumeLayout(false);
            this.viewASpecificFlightPanel.PerformLayout();
            this.deleteCustomerPanel.ResumeLayout(false);
            this.deleteCustomerPanel.PerformLayout();
            this.deleteFlightPanel.ResumeLayout(false);
            this.deleteFlightPanel.PerformLayout();
            this.addFlightPanel.ResumeLayout(false);
            this.addFlightPanel.PerformLayout();
            this.addBookingPanel.ResumeLayout(false);
            this.addBookingPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.alternateWelcomePanel.ResumeLayout(false);
            this.alternateWelcomePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAddCustomer;
        private System.Windows.Forms.ToolStripMenuItem btnViewCustomers;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteCustomer;
        private System.Windows.Forms.ToolStripMenuItem btnAddFlight;
        private System.Windows.Forms.ToolStripMenuItem btnViewAllFlights;
        private System.Windows.Forms.ToolStripMenuItem btnViewASpecificFlight;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteFlight;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAddBooking;
        private System.Windows.Forms.ToolStripMenuItem btnViewAllBookings;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Panel addCustomerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegisterCustomer;
        private System.Windows.Forms.Label lblAddCustomerOutput;
        private System.Windows.Forms.Panel deleteCustomerPanel;
        private System.Windows.Forms.Label lblDeleteCustomerOutput;
        private System.Windows.Forms.Button btnDeleteCust;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustomerIdDelete;
        private System.Windows.Forms.Panel viewASpecificFlightPanel;
        private System.Windows.Forms.Label lblViewSpecificFlightOutput;
        private System.Windows.Forms.Button btnActualViewSpecificFlight;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFlightNumberView;
        private System.Windows.Forms.Panel deleteFlightPanel;
        private System.Windows.Forms.Label lblDeleteFlightOutput;
        private System.Windows.Forms.Button btnActualDeleteFlight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFlightNumberDelete;
        private System.Windows.Forms.Panel addFlightPanel;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtMaxSeats;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAddFlightOutput;
        private System.Windows.Forms.Button btnActualAddFlight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.Panel addBookingPanel;
        private System.Windows.Forms.TextBox txtFlightNumberBooking;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAddBookingOuput;
        private System.Windows.Forms.Button btnActualAddBooking;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCustomerIdBooking;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtMaxNumBooking;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtMaxNumCust;
        private System.Windows.Forms.TextBox txtMaxNumFlight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblWelcomeOutput;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel alternateWelcomePanel;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label28;
    }
}

