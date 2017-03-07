using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models;

namespace WebApplication4.Models
{
    public class CVClass : CVULTRACLASS
    {
        public PersonalStatment ps { get; set; }
        public EducationLevel eduLvl { get; set; }

    }
}