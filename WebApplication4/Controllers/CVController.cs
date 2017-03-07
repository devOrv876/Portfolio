using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;
using WebApplication4.ViewModel;

namespace WebApplication4.Controllers
{
    public class CVController : Controller
    {


        private CVContext cvcontext = new CVContext();
        // GET: CV
        public ActionResult CV()
        {
                         
            //List<CVContext> cv = new List<CVContext>();

            CvViewModel model = new CvViewModel();

            model.personal = cvcontext.personalstatment.ToList();
            model.instit = cvcontext.institution.ToList();
            model.edu = cvcontext.education.ToList();


            return View(model);
        }

    }
}



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