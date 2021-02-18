using System;

namespace ClassLibrary1
{
    public class Room
    {   
        private int roomNumber;
        private int numberOfBeds;
        private string quality;

        public Room(int nr, int nrBeds, string q)
        {
            this.roomNumber = nr;
            this.numberOfBeds = nrBeds;
            this.quality = q;
        }

        
    }
}
