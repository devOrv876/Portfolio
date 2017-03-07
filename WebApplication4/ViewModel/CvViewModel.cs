using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models;

namespace WebApplication4.ViewModel
{
    public class CvViewModel
    {
        public List<PersonalStatmentModel> personal { get; set; }
        public List<InstitutionModel> instit { get; set; }

        public List<EducationModel> edu { get; set; }

        //public List<QualificationModel> qual { get; set; }


    }
}