using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Reservation
    {
        private int reservationNumber { get; set; }
        private DateTime arrivalDay { get; set; }
        private DateTime departureDay { get; set; }
        private double price { get; set; }
        private int cid { get; set; } //Customer kanskje?
        private int roomNumber { get; set; }

        public Reservation(int r, DateTime a, DateTime d, double p, int c, int rNr)
        {
            this.reservationNumber = r;
            this.arrivalDay = a;
            this.departureDay = d;
            this.price = p;
            this.cid = c;
            this.roomNumber = rNr;
        }
    }
}
