using Microsoft.AspNetCore.Mvc;

namespace FeatureFolderDemo.MVC.Features.ErrorPage.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error()
        {
            return View();
        }
    }
}
