using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace Desktop.Models
{
    public class Customer
    {
        [Key]
        public int Cid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string Password { get; set; }
    }
}