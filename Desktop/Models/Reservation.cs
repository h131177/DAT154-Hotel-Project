using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace Desktop.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationNumber { get; set; }
        public DateTime ArrivalDay { get; set; }
        public DateTime DepartureDay { get; set; }
        public double Price { get; set; }
        public int Cid { get; set; }
        public int RoomNumber { get; set; }
    }
}
