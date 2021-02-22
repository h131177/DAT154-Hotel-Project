using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Customer
    {
        private int cid { get; set; }
        private string name { get; set; }
        private string address { get; set; }
        private int zipCode { get; set; }
        private string password { get; set; }

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
