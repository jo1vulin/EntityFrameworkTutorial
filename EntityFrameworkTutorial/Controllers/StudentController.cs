using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFrameworkTutorial.DAL;

namespace EntityFrameworkTutorial.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/

        public SchoolContext db = new SchoolContext();

        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

    }
}
