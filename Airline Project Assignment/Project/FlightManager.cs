using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class FlightManager
    {
        private int maxFlights;
        private int numFlights;
        private Flight[] flightList;

        public int MaxFlights { set { maxFlights = value; } get { return maxFlights; } }
        public int NumFlights { set { numFlights = value; } get { return numFlights; } }
        public Flight[] FlightList { set { flightList = value; } get { return flightList; } }

        public FlightManager(int max)
        {
            maxFlights = max;
            numFlights = 0;
            flightList = new Flight[maxFlights];
        }

        public bool addFlight(int fn, string origin, string destination, int maxSeats)
        {
            if (numFlights >= maxFlights) { return false; }
            for (int i = 0; i < numFlights; i++)
            {
                if (flightList[i].getFlightNumber().Equals(fn)) { return false; }
            }
            Flight f = new Flight(fn, origin, destination, maxSeats);
            flightList[numFlights] = f;
            numFlights++;
            return true;
        }

        private int findFlight(int fid)
        {
            for (int x = 0; x < numFlights; x++)
            {
                if (flightList[x].getFlightNumber() == fid)
                    return x;
            }
            return -1;
        }

        public bool flightExists(int fid)
        {
            int loc = findFlight(fid);
            if (loc == -1) { return false; }
            return true;
        }

        public Flight getFlight(int fid)
        {
            int loc = findFlight(fid);
            if (loc == -1) { return null; }
            return flightList[loc];
        }

        public bool deleteFlight(int fid)
        {
            int loc = findFlight(fid);
            // 2 cases either flight doesn't exist or flight has people on it will return false
            if (loc == -1 || flightList[loc].getNumPassengers() > 0) { return false; }
            flightList[loc] = flightList[numFlights - 1];
            numFlights--;
            return true;
        }

        public string getFlightList()
        {
            string s = "List of Flights";
            for (int x = 0; x < numFlights; x++)
            {
                s += "\n-----------------------------------------------------------------------------------------------------------------------------------";
                s = s + "\nFlight Number: " + flightList[x].getFlightNumber() + " - From " + flightList[x].getOrigin() + " to " + flightList[x].getDestination();
            }
            return s;
        }

        public string viewASpecificFlight(int flightNumber)
        {
            if (getFlight(flightNumber) is null)
            {
                return "Flight does not exist";
            }
            return getFlight(flightNumber).toString();
        }

        public int getAvailableNumFlight()
        {
            return maxFlights - numFlights;
        }
    }
}
