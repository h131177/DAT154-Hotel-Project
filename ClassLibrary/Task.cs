using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Task
    {
        private int roomnr { get; set; }
        private string type { get; set; }
        private string task { get; set; }
        private string note { get; set; }
        private string status { get; set; }
        private int eid { get; set; }

        public Task(int roomnr, string type, string task, string note, string status, int eid)
        {
            this.roomnr = roomnr;
            this.type = type;
            this.task = task;
            this.note = note;
            this.status = status;
            this.eid = eid;
        }

    }
}
