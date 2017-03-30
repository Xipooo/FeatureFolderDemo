using Microsoft.AspNetCore.Mvc;

namespace FeatureFolderDemo.MVC.Features.ContactPage.Controllers
{
    public class ContactPageController : Controller
    {
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
    }
}
