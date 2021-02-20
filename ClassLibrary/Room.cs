using System;

namespace ClassLibrary1
{
    public class Room
    {   
        private int roomNumber;
        private int numberOfBeds;
        private string quality;
        private bool checkedIn;
        private int rid;

        public Room(int nr, int nrBeds, string q, bool c, int r)
        {
            this.roomNumber = nr;
            this.numberOfBeds = nrBeds;
            this.quality = q;
            this.checkedIn = c;
            this.rid = r;
        }

        
    }
}
