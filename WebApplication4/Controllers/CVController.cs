using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;
using WebApplication4.ViewModel;
using Portfolio.Models;
using System.Data.Entity;

namespace WebApplication4.Controllers
{
    public class CVController : Controller
    {
        private CVContext cvcontext = new CVContext();

        //Model1 dbModel = new Model1();
        
        
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


        [HttpGet]
        public ActionResult FullEdit()
        {
            return View();

        }

        [HttpPost]
        public ActionResult FullEdit(CvViewModel model)
        {
            updatePs(model);
            updateEdu(model);
            
            return RedirectToAction("CV");
        }

        [HttpGet]
        public ActionResult CvEdit()
        {
            return PartialView();
        }



        [HttpPost]
        public ActionResult CvEdit(CvViewModel model)
        {
            updatePs(model);

            return RedirectToAction("CV");
        }


        public void updatePs(CvViewModel model)
        {
            PersonalStatment ps;
            int id = model.personal[0].iD;
            //1. Get statement from DB
            using (var db = new CVContext())
            {
                ps = db.personal.Where(s => s.iD == id).FirstOrDefault();
            }


            //2. change statement in disconnected mode (out of ctx scope)
            if (ps != null)
            {
                ps.PStatment = model.personal[0].PStatment;
            }

            //save modified entity using new Context
            using (var dbtx = new CVContext())
            {
                //3. Mark entity as modified
                dbtx.Entry(ps).State = EntityState.Modified;

                //4. call SaveChanges
                dbtx.SaveChanges();
            }

        }

        public void updateEdu(CvViewModel model)
        {
            PersonalStatment ps;
            int id = model.qual[0].EduLevel_ID.Value;
            
            //1. Get statement from DB
            using (var db = new CVContext())
            {
                ps = db.personal.Where(s => s.iD == id).FirstOrDefault();

            }

            //2. change statement in disconnected mode (out of ctx scope)
            if (ps != null)
            {
                ps.PStatment = model.personal[0].PStatment;
            }

            //save modified entity using new Context
            using (var dbtx = new CVContext())
            {
                //3. Mark entity as modified
                dbtx.Entry(ps).State = EntityState.Modified;
              
                //4. call SaveChanges
                dbtx.SaveChanges();

            }
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