using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkBasics
{
    public class Users //baza lekarzy i laborantów
    {
        public int UserId { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public string Email { get; set; }
        public int Role { get; set; } //0-lekarz, 1-logistyk
        public String Password { get; set; }
    }
}
