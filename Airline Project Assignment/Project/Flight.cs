using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Flight
    {
        private int flightNumber;
        private string origin;
        private string destination;
        private int maxSeats;
        private int numPassengers;
        private Customer[] passengers;

        public int FlightNumber { set { flightNumber = value; } get { return flightNumber; } }
        public string Origin { set { origin = value; } get { return origin; } }
        public string Destination { set { destination = value; } get { return destination; } }
        public int MaxSeats { set { maxSeats = value; } get { return maxSeats; } }
        public int NumPassengers { set { numPassengers = value; } get { return numPassengers; } }
        public Customer[] Passengers { set { passengers = value; } get { return passengers; } }


        public Flight(int fn, string or, string dest, int mSeats)
        {
            maxSeats = mSeats;
            flightNumber = fn;
            origin = or;
            destination = dest;
            numPassengers = 0;
            passengers = new Customer[maxSeats];
        }

        public int getFlightNumber() { return flightNumber; }
        public string getOrigin() { return origin; }
        public string getDestination() { return destination; }
        public int getMaxSeats() { return maxSeats; }
        public int getNumPassengers() { return numPassengers; }

        public bool addPassenger(Customer c)
        {
            if (numPassengers >= maxSeats) { return false; }
            passengers[numPassengers] = c;
            numPassengers++;
            return true;
        }

        private int findPassenger(int custId)
        {
            for (int x = 0; x < maxSeats; x++)
            {
                if (passengers[x].getId() == custId)
                    return x;
            }
            return -1;
        }

        public bool removePassenger(int custId)
        {
            int loc = findPassenger(custId);
            if (loc == -1) return false;
            passengers[loc] = passengers[numPassengers - 1];
            numPassengers--;
            return true;
        }

        public string getPassengerList()
        {
            string s = "\nPassengers on flight " + flightNumber + ":";
            for (int x = 0; x < numPassengers; x++)
            {
                s = s + "\n" + passengers[x].getFirstName() + " " + passengers[x].getLastName();
            }
            return s;
        }

        public string toString()
        {
            string s = "Flight Number: " + flightNumber;
            s = s + "\nOrigin: " + origin;
            s = s + "\nDestination: " + destination;
            s = s + "\nNumber of Passengers: " + numPassengers;
            s = s + "\nAvailable seats: " + (maxSeats - numPassengers);
            if (numPassengers == 0)
                s = s + "\nThere are no passengers on this flight";
            else
                s = s + getPassengerList();
            return s;
        }
    }
}
