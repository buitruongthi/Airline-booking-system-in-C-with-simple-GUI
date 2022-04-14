using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class BookingManager
    {
        private int maxBooking;
        private int numBooking;
        private Booking[] bookingList;

        public int MaxBooking { set { maxBooking = value; } get { return maxBooking; } }
        public int NumBooking { set { numBooking = value; } get { return numBooking; } }
        public Booking[] BookingList { set { bookingList = value; } get { return bookingList; } }

        public BookingManager(int maxBooking)
        {
            numBooking = 0;
            this.maxBooking = maxBooking;
            bookingList = new Booking[maxBooking];
        }

        public bool addBooking(int bookingNum, Flight f, Customer c)
        {
            if (numBooking >= maxBooking) { return false; }
            bookingList[numBooking] = new Booking(bookingNum, f, c);
            numBooking++;
            return true;
        }

        public int getNumBooking() { return numBooking; }

        public string viewBookings()
        {
            string s = "List of bookings";
            for (int i = 0; i < numBooking; i++)
            {
                s += "\n-----------------------------------------------------------------------------------------------------------------------------------";
                s += "\n" + bookingList[i];
            }
            return s;
        }

        public int getAvailablNumBooking()
        {
            return maxBooking - numBooking;
        }
    }
}
