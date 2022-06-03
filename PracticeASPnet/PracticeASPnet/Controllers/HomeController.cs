using Microsoft.AspNetCore.Mvc;

namespace PracticeASPnet.Controllers
{
    public class HomeController : Controller
    {


        public ViewResult Index()
        {
            return View();
        }

        public ViewResult About()
        {
            var view = new ViewResult();
            view.ViewName = "About";
            return view;
        }
    }
}