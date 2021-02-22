using System;

namespace ClassLibrary1
{
    public class Room
    {   
        private int roomNumber { get; set; }
        private int numberOfBeds { get; set; }
        private string quality { get; set; }
        private bool checkedIn { get; set; }
        private int rid { get; set; }

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
