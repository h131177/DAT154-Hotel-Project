using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Reservation
    {
        private int reservationNumber;
        private string arrivalDay; //DateTime kanskje?
        private string departureDay; //DateTime kanskje?
        private double price;
        private int cid; //Customer kanskje?
        private int roomNumber;

        public Reservation(int r, string a, string d, double p, int c, int rNr)
        {
            this.reservationNumber = r;
            this.arrivalDay = a;
            this.departureDay = d;
            this.price = p;
            this.cid = c;
            this.roomNumber = rNr;
        }
        
        //given time periode for the hotel room
        //let user search for different wishes.
    }
}
