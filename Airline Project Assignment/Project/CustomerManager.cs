using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class CustomerManager
    {
        private int maxCustomer;
        private int numCustomer;
        private Customer[] customerList;

        public int MaxCustomer { set { maxCustomer = value; } get { return maxCustomer; } }
        public int NumCustomer { set { numCustomer = value; } get { return numCustomer; } }
        public Customer[] CustomerList { set { customerList = value; } get { return customerList; } }

        public CustomerManager(int maxCustomer)
        {
            this.maxCustomer = maxCustomer;
            numCustomer = 0;
            customerList = new Customer[maxCustomer];
        }

        public bool addCustomer(int cId, string fname, string lname, string ph)
        {
            if (numCustomer >= maxCustomer) { return false; }
            for (int i = 0; i < numCustomer; i++)
            {
                if (customerList[i].getFirstName().Equals(fname) && customerList[i].getLastName().Equals(lname) && customerList[i].getPhone().Equals(ph))
                {
                    return false;
                }
            }
            Customer c = new Customer(cId, fname, lname, ph);
            customerList[numCustomer] = c;
            numCustomer++;
            return true;
        }

        private int getCustomerLoc(int cId)
        {
            for (int i = 0; i < numCustomer; i++)
            {
                if (customerList[i].getId() == cId)
                {
                    return i;
                }
            }
            return -1;
        }

        public string viewCustomer(int cId)
        {
            int loc = getCustomerLoc(cId);
            if (loc == -1) { return "Customer not found"; }
            return "First Name: " + customerList[loc].getFirstName()
                + "\nLast Name: " + customerList[loc].getLastName()
                + "\nPhone: " + customerList[loc].getPhone();
        }

        public bool deleteCustomer(int cId)
        {
            int loc = getCustomerLoc(cId);
            if (loc == -1 || customerList[loc].getNumBookings() > 0) { return false; }
            customerList[loc] = customerList[numCustomer - 1];
            numCustomer--;
            return true;
        }

        public Customer getCustomer(int id)
        {
            int loc = getCustomerLoc(id);
            if (loc == -1) { return null; }
            return customerList[loc];
        }

        public string viewCustomers()
        {
            string s = "List of Customers";
            for (int i = 0; i < numCustomer; i++)
            {
                s += "\n-----------------------------------------------------------------------------------------------------------------------------------";
                s += "\n" + customerList[i].toString();
            }
            return s;
        }

        public int getNumCustomer() { return numCustomer; }
        public int getAvailableNumCust() { return maxCustomer - numCustomer; }
    }
}
