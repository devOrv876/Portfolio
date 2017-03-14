using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;
using WebApplication4.ViewModel;
using Portfolio.Models;

namespace WebApplication4.Controllers
{
    public class CVController : Controller
    {


        private CVContext cvcontext = new CVContext();
        Model1 dbModel = new Model1();
        

        // GET: CV
        public ActionResult CV()
        {
           
            CvViewModel model = new CvViewModel();

            //model.edu = dbModel.tblEducationLevels.ToList();
            //model.instit = dbModel.tblInstitutions.ToList();
            //model.personal = dbModel.tblPersonalStatements.ToList();
            //model.qual = dbModel.tblQualifications.ToList();


            model.edu = cvcontext.education.ToList();
            model.qual = cvcontext.qualification.ToList();
            model.personal = cvcontext.personal.ToList();
            model.instit = cvcontext.institute.ToList();

            return View(model);
        }

    }
}


//List<CVContext> cv = new List<CVContext>();
//EducationLevel edu = new EducationLevel
//{

//};

//PersonalStatment ps = new PersonalStatment

//{
//    personalStatment = cvdbconnect.GetPS(PSCmd) +
//            };








//string PSCmd = "Select * FROM personalstatment";
//CVDBConnect cvdbconnect = new CVDBConnect();

//CVULTRACLASS.PersonalStatment ps = new CVULTRACLASS.PersonalStatment()
//{

//   personalStatment = cvdbconnect.GetPS(PSCmd)

//};