using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Booking
    {
        private string date;
        private int bookingNumber;
        private Flight flight;
        private Customer customer;

        public string Date { set { date = value; } get { return date; } }
        public int BookingNumber { set { bookingNumber = value; } get { return bookingNumber; } }
        public Flight Flight { set { flight = value; } get { return flight; } }
        public Customer Customer { set { customer = value; } get { return customer; } }


        public Booking(int bookingNumber, Flight flight, Customer customer)
        {
            date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
            this.flight = flight;
            this.customer = customer;
            this.bookingNumber = bookingNumber;
            customer.updateNumBookings();
        }


        public override string ToString()
        {
            return "Booking was made on: " + date
                + "\nBooking Number: " + bookingNumber
                + "\nCustomer Name: " + customer.getFirstName() + " " + customer.getLastName()
                + "\nFlight Number: " + flight.getFlightNumber();
        }
    }
}
