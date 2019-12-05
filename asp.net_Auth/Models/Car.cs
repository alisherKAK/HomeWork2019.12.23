using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp.net_Auth.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string  Wheel { get; set; }
        public int DoorCount { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}