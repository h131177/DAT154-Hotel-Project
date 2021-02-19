using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Task
    {
        private int roomnr;
        private String note;
        private String status;

        public Task (int roomnr, String note, String status)
        {
            this.roomnr = roomnr;
            this.note = note;
            this.status = status;
        }

    }
}
