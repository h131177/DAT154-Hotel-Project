using System;
using System.Data.Entity;
using System.Linq;

namespace ClassLibrary.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string Password { get; set; }
        public bool CheckedIn { get; set; }
    }
}