using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        private AirlineCoordinator aCoord;
        private const int numFlightLimit = 5000, numCustLimit = 50000, numBookingLimit = 500000, numSeatLimit = 1000;
        private string jsonFile = "airlineCoordinator.json";

        public Form1()
        {
            aCoord = loadACoord(jsonFile);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // show the panel for creating coordinator object if it's the first time user opens the program
            if (aCoord is null)
                showPanel(welcomePanel);
            else
            {
                mainMenu.Show();
                showPanel(alternateWelcomePanel);
            }
            outputBox.Text = "Please save your progress by clicking File -> Save." +
                "\nAll input numbers (flight number, max number of bookings, etc.) can't be zero." +
                "\n--------------------------------------------------------------------------------------------------------------------" +
                "\nDue to the limitations of the system we currently only allow:" +
                "\nUp to: " + numFlightLimit + " flights" +
                "\nUp to: " + numCustLimit + " customers" +
                "\nUp to: " + numBookingLimit + " bookings" +
                "\nWe apologize for the inconvenience.";
            outputBox.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveACoord(jsonFile);
            outputBox.Text = "Saved";
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            lblAddFlightOutput.Text = "";
            showPanel(addFlightPanel);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            lblAddCustomerOutput.Text = "";
            showPanel(addCustomerPanel);
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            showCustomerList();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            lblDeleteCustomerOutput.Text = "";
            showCustomerList();
            showPanel(deleteCustomerPanel);
        }


        private void btnRegisterCustomer_Click(object sender, EventArgs e)
        {
            int cId;
            string fName, lName, ph;
            string errorText = "Missing information:";
            cId = aCoord.getNumCustomer() + 1;
            fName = txtFirstName.Text;
            lName = txtLastName.Text;
            ph = txtPhone.Text;
            bool addOk = true;
            if (String.IsNullOrEmpty(fName)) { addOk = false; errorText += " First name"; }
            if (String.IsNullOrEmpty(lName)) { addOk = false; errorText += " Last name"; }
            if (String.IsNullOrEmpty(ph)) { addOk = false; errorText += " Phone number"; }
            if (addOk)
            {
                if (aCoord.addCustomer(cId, fName, lName, ph))
                {
                    lblAddCustomerOutput.Text = "Customer successfully added";
                    showCustomerList();
                }
                else
                    lblAddCustomerOutput.Text = "This customer is already in the system\nor maximum number of customer has been reached" +
                        "\nNumber of customers can be added to the system: " + aCoord.getAvailableNumCust();
            }
            else
            {
                lblAddCustomerOutput.Text = errorText;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            saveACoord(jsonFile);
            Application.Exit();
        }

        // Hide all panels except the one taken in as parameter
        private void showPanel(Panel panel)
        {
            Panel[] panels = { deleteCustomerPanel, addCustomerPanel, addFlightPanel, viewASpecificFlightPanel, deleteFlightPanel, addBookingPanel , welcomePanel, alternateWelcomePanel };
            for (int i = 0; i < panels.Length; i++)
            {
                panels[i].Visible = false;
            }
            panel.Visible = true;
            panel.Top = 100;
            panel.Left = 30;
        }

        private void showCustomerList()
        {
            outputBox.Text = aCoord.viewCustomers();
            outputBox.Show();
        }

        private void showFlightList()
        {
            outputBox.Text = aCoord.viewFlights();
            outputBox.Show();
        }

        private void showBookingList()
        {
            outputBox.Text = aCoord.viewBookings();
            outputBox.Show();
        }


        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
            int cId = getValidPosInt(txtCustomerIdDelete.Text);
            if (cId != -1)
            {
                if (aCoord.deleteCustomer(cId))
                {
                    lblDeleteCustomerOutput.Text = "Deleted customer with Id: " + cId;
                    showCustomerList();
                }
                else
                    lblDeleteCustomerOutput.Text = "Customer was not deleted\nId not found or customer has bookings";
            }
            else
                lblDeleteCustomerOutput.Text = "Please enter a positive integer";
        }

        // Get int >= 1
        private int getValidPosInt(string text)
        {
            int value;
            if (!int.TryParse(text, out value) || value <= 0)
                return -1;
            return value;
        }

        // File related functions
        private AirlineCoordinator loadACoord(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader file = File.OpenText(filePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    return (AirlineCoordinator)serializer.Deserialize(file, typeof(AirlineCoordinator));
                }
            }
            return null;
        }

        private void saveACoord(string filePath)
        {
            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(file, aCoord);
            }
        }

        private void btnActualAddFlight_Click(object sender, EventArgs e)
        {
            int flightNumber, maxNumSeats;
            string origin, destination;
            string errorText = "Missing information:";
            flightNumber = getValidPosInt(txtFlightNumber.Text);
            maxNumSeats = getValidPosInt(txtMaxSeats.Text);
            origin = txtOrigin.Text;
            destination = txtDestination.Text;
            bool addOk = true;
            if (String.IsNullOrEmpty(origin)) { addOk = false; errorText += " Origin"; }
            if (String.IsNullOrEmpty(destination)) { addOk = false; errorText += " Destination"; }
            if (flightNumber == -1) { addOk = false; errorText += "\nFlight Number must be a positive integer"; }
            if (maxNumSeats == -1 || maxNumSeats > numSeatLimit) { addOk = false; errorText += "\nMax seats must be a positive int no more than " + numSeatLimit; }
            if (addOk)
            {
                if (aCoord.addFlight(flightNumber, origin, destination, maxNumSeats))
                {
                    lblAddFlightOutput.Text = "Flight successfully added";
                    showFlightList();
                }
                else
                    lblAddFlightOutput.Text = "Flight with flight number: " + flightNumber + " already exists\nor maxmimum number of flights reached" +
                        "\nNumber of flights can be added to the system: " + aCoord.getAvailableNumFlight();
            }
            else
            {
                lblAddFlightOutput.Text = errorText;
            }
        }

        private void btnViewAllFlights_Click(object sender, EventArgs e)
        {
            showFlightList();
        }

        private void btnActualViewSpecificFlight_Click(object sender, EventArgs e)
        {
            int flightNumber = getValidPosInt(txtFlightNumberView.Text);
            if (flightNumber == -1) { lblViewSpecificFlightOutput.Text = "Flight Number must be positive int"; }
            else
            {
                outputBox.Text = aCoord.viewASpecificFlight(flightNumber);
                lblViewSpecificFlightOutput.Text = "";
            }
        }

        private void btnViewASpecificFlight_Click(object sender, EventArgs e)
        {
            showFlightList();
            showPanel(viewASpecificFlightPanel);
        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            lblDeleteFlightOutput.Text = "";
            showFlightList();
            showPanel(deleteFlightPanel);
        }

        private void btnActualDeleteFlight_Click_1(object sender, EventArgs e)
        {
            int flightNumber = getValidPosInt(txtFlightNumberDelete.Text);
            if (flightNumber == -1) { lblDeleteFlightOutput.Text = "Flight Number must be positive integer"; }
            else if (aCoord.deleteFlight(flightNumber))
            {
                lblDeleteFlightOutput.Text = "Deleted flight number " + flightNumber;
                showFlightList();
            }
            else
            {
                lblDeleteFlightOutput.Text = "Failed to delete flight\nEither flight number does not exist\nOr flight contains passengers";
            }
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            lblAddBookingOuput.Text = "";
            outputBox.Text = aCoord.viewFlights() + "\n\n" + aCoord.viewCustomers();
            outputBox.Show();
            showPanel(addBookingPanel);
        }

        private void btnActualAddBooking_Click(object sender, EventArgs e)
        {
            int flightNumber = getValidPosInt(txtFlightNumberBooking.Text);
            int cId = getValidPosInt(txtCustomerIdBooking.Text);
            int bookingId = aCoord.getNumBooking() + 1;
            if (flightNumber == -1 || cId == -1)
            {
                lblAddBookingOuput.Text = "Flight number and customer id must be positive integer";
            } 
            else
            {
                if (aCoord.addBooking(bookingId, cId, flightNumber))
                {
                    lblAddBookingOuput.Text = "Added customer with id " + cId + " to flight number " + flightNumber;
                    showBookingList();
                }
                else
                    lblAddBookingOuput.Text = "Customer Id or flight number not found or the flight is full\n" +
                        "Please verify there are vacant seats by selecting View Specific flight" +
                        "\nNumber of bookings can be added to the system: " + aCoord.getAvailableNumBooking();
            }
        }

        private void btnViewAllBookings_Click(object sender, EventArgs e)
        {
            showBookingList();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int maxFlight = getValidPosInt(txtMaxNumFlight.Text);
            int maxCustomer = getValidPosInt(txtMaxNumCust.Text);
            int maxBooking = getValidPosInt(txtMaxNumBooking.Text);
            if (maxFlight == -1 || maxCustomer == -1 || maxBooking == -1 || maxFlight > numFlightLimit || maxCustomer > numCustLimit || maxBooking > numBookingLimit)
            {
                lblWelcomeOutput.Text = "All three values must be postive integer and within\nThe specified ranges from the right side panel";
            }
            else
            {
                aCoord = new AirlineCoordinator(maxCustomer, maxFlight, maxBooking);
                lblWelcomeOutput.Text = "You can now begin by selecting operations\nin the top left corner menu";
                btnSubmit.Visible = false;
                mainMenu.Show();
            }
        }
    }
}
