using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Customer
    {
        private int cid;
        private string name;
        private string address;
        private int zipCode;
        private string password;

        public Customer(int c, string n, string a, int z, string p)
        {
            this.cid = c;
            this.name = n;
            this.address = a;
            this.zipCode = z;
            this.password = p;
        }
        //Innlogging - skal kunne sjå informasjonen om reservasjonen.
        //Utlogging - tar deg tilbake til hovedsida.

    }
}
