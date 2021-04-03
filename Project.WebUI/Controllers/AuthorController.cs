using Project.BLL.DesignPatterns.RepositoryPattern.ConcRep;
using Project.VM.VMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.WebUI.Controllers
{
    public class AuthorController : Controller
    {

        AuthorRepository authRep;

        public AuthorController()
        {
            authRep = new AuthorRepository();
        }


        // GET: Author
        public ActionResult AuthorList()
        {
            AuthorVM auvm = new AuthorVM
            {
                Authors = authRep.GetActives()
            };
            return View(auvm);
        }
    }
}