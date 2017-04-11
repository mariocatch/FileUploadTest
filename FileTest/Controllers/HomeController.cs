using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace FileTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var vm = new ViewModel();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(ViewModel vm)
        {
            if (ModelState.IsValid)
            {
                foreach (string file in Request.Files)
                {
                    var tempFile = Request.Files[file];
                }

                ViewData.Add("Success", true);
                return View();
            }

            return View(vm);
        }
    }

    public class ViewModel
    {
        public string Name { get; set; }
        public IEnumerable<HttpPostedFileBase> Files { get; set; }
    }
}