using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string phone;
        private int bookings;

        public int CustomerId { set { customerId = value; } get { return customerId; } }
        public string FirstName { set { firstName = value; } get { return firstName; } }
        public string LastName { set { lastName = value; } get { return lastName; } }
        public string Phone { set { phone = value; } get { return phone; } }
        public int Bookings { set { bookings = value; } get { return bookings; } }

        public Customer(int cId, string fname, string lname, string ph)
        {
            bookings = 0;
            customerId = cId;
            firstName = fname;
            lastName = lname;
            phone = ph;
        }

        public int getId() { return customerId; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getPhone() { return phone; }
        public int getNumBookings() { return bookings; }
        public void updateNumBookings() { bookings++; }
        public string toString()
        {
            string s = "Customer Id: " + customerId;
            s = s + " - First Name: " + firstName + " Last Name: " + lastName;
            s = s + " - Phone: " + phone;
            s = s + " - Bookings: " + bookings;
            return s;
        }
    }
}
