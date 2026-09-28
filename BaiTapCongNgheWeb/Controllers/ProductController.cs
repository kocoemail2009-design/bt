using Microsoft.AspNetCore.Mvc;

namespace BaiTapCongNgheWeb.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
