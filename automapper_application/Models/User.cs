using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace automapper_application.Models
{
    // The model you want to map from
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        // Constructor to initialize User
        public User()
        {
            Name = "Sumon";
            Email = "sumu2007@gmail.com";
            Phone = "+8801915521851";
        }
    }
}
