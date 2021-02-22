using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Reservation
    {
        private int reservationNumber { get; set; }
        private string arrivalDay { get; set; } //DateTime kanskje?
        private string departureDay { get; set; } //DateTime kanskje?
        private double price { get; set; }
        private int cid { get; set; } //Customer kanskje?
        private int roomNumber { get; set; }

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
