using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class AirlineCoordinator
    {
        FlightManager flManager;
        CustomerManager custManager;
        BookingManager bookingManager;

        public FlightManager FlManager { set { flManager = value; } get { return flManager; } }
        public CustomerManager CustManager { set { custManager = value; } get { return custManager; } }
        public BookingManager BookingManager { set { bookingManager = value; } get { return bookingManager; } }


        public AirlineCoordinator(int maxCust, int maxFlights, int maxBooking)
        {
            flManager = new FlightManager(maxFlights);
            custManager = new CustomerManager(maxCust);
            bookingManager = new BookingManager(maxBooking);
        }

        public bool addFlight(int flightNo, string origin, string destination, int maxSeats)
        {
            return flManager.addFlight(flightNo, origin, destination, maxSeats);
        }


        public string flightList()
        {
            return flManager.getFlightList();
        }


        public bool deleteFlight(int fid)
        {
            return flManager.deleteFlight(fid);
        }

        public string viewFlights()
        {
            return flManager.getFlightList();
        }

        public string viewASpecificFlight(int fid)
        {
            return flManager.viewASpecificFlight(fid);
        }

        public bool addBooking(int bookingId, int cid, int fid)
        {
            Flight f = flManager.getFlight(fid);
            Customer c = custManager.getCustomer(cid);
            if (f is null || c is null || f.getNumPassengers() >= f.getMaxSeats())
            {
                return false;
            }
            if (bookingManager.addBooking(bookingId, f, c))
            {
                f.addPassenger(c);
                return true;
            }
            return false;
        }

        public string viewBookings()
        {
            return bookingManager.viewBookings();
        }

        public bool addCustomer(int cId, string fname, string lname, string ph)
        {
            return custManager.addCustomer(cId, fname, lname, ph);
        }

        public string viewCustomers()
        {

            return custManager.viewCustomers();
        }

        public bool deleteCustomer(int cid)
        {
            return custManager.deleteCustomer(cid);
        }

        public int getNumBooking()
        {
            return BookingManager.getNumBooking();
        }

        public int getNumCustomer()
        {
            return custManager.getNumCustomer();
        }

        public int getAvailableNumCust()
        {
            return custManager.getAvailableNumCust(); 
        }

        public int getAvailableNumFlight()
        {
            return flManager.getAvailableNumFlight();
        }

        public int getAvailableNumBooking()
        {
            return bookingManager.getAvailablNumBooking();
        }
    }
}
