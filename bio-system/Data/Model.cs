using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkBasics
{
  
    public class Patients
    {
        public int PatientId { get; set; }
        public int PESEL { get; set; }
        public String name { get; set; }
        public String surname { get; set; }
        public int nrtel { get; set; }
        public String gr_krwi { get; set; }
        public int UserId { get; set; }


    }

    
}