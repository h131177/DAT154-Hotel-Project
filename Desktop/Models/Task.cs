using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace Desktop.Models
{
    public enum Type
    {
        CLEAN, MAINTAINCE, SERVICE
    }
    public enum Status
    {
        NEW, IN_PROGRESS, FINISHED
    }
    public class Task
    {
        [Key]
        public int Roomnr { get; set; }
        public Type? Type { get; set; }
        public string Task_ { get; set; }
        public string Note { get; set; }
        public Status? Status { get; set; }
        public int Eid { get; set; }
    }
}
