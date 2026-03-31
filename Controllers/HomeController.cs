using Microsoft.AspNetCore.Mvc;
using AliPortfolio.Models;

namespace AliPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = PortfolioData.GetData();
            return View(model);
        }
    }
}
