using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace automapper_application.Models
{
    // The data transfer object you want to map to
    public class UserDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
