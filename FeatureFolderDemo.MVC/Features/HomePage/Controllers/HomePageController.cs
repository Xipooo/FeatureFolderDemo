using Microsoft.AspNetCore.Mvc;

namespace FeatureFolderDemo.MVC.Features.HomePage.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
