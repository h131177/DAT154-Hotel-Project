using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace ClassLibrary.Models
{
    public class Room
    {
        [Key]
        public int RoomNumber { get; set; }
        public int NumberOfBeds { get; set; }
        public string Quality { get; set; }
        public int Rid { get; set; }
    }
}
