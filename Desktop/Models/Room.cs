using System;
using System.Data.Entity;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Desktop.Models
{
    public class Room
    {
        [Key]
        public int RoomNumber { get; set; }
        public int NumberOfBeds { get; set; }
        public string Quality { get; set; }
        public bool CheckedIn { get; set; }
        public int Rid { get; set; }
    }
}
