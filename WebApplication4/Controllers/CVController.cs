using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class CVController : Controller
    {
        // GET: CV
        public ActionResult CV(int id)
        {         
                       
            CVContext cvcontext = new CVContext();
            cvcontext.personalstatment



           
            

            
            return View();
        }

    }
//}
//string PSCmd = "Select * FROM personalstatment WHERE ID = @0";
//CVDBConnect cvdbconnect = new CVDBConnect();
//PersonalStatment ps = new PersonalStatment
//{
//    personalStatment = cvdbconnect.GetPS(PSCmd)
// };
