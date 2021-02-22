using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Task
    {
        private int roomnr { get; set; }
        private String note { get; set; }
        private String status { get; set; }

        public Task (int roomnr, String note, String status)
        {
            this.roomnr = roomnr;
            this.note = note;
            this.status = status;
        }

    }
}
