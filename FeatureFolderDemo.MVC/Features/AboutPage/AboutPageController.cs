using Microsoft.AspNetCore.Mvc;

namespace FeatureFolderDemo.MVC.Features.AboutPage.Controllers
{
    public class AboutPageController : Controller
    {
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
    }
}
