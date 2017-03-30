using Microsoft.AspNetCore.Mvc;

namespace FeatureFolderDemo.MVC.Features.ErrorPage
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error()
        {
            return View();
        }
    }
}
