using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models;
using Portfolio.Models;

namespace WebApplication4.ViewModel
{
    public class CvViewModel
    {


        public List<PersonalStatment> personal { get; set; }

        public List<Institution> instit { get; set; }

        public List<EducationLevel> edu { get; set; }

        public List<Qualification> qual { get; set; }



        //public List<tblPersonalStatement> personal { get; set; }

        //public List<tblInstitution> instit { get; set; }

        //public List<tblEducationLevel> edu { get; set; }

        //public List<tblQualification> qual { get; set; }


    }
}