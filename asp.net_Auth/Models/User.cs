using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp.net_Auth.Models
{
    public class User : ApplicationUser
    {
        public int Age { get; set; }
        public bool Gender { get; set; }
        public virtual IList<Car> Cars { get; set; } = new List<Car>();
    }
}