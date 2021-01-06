using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using WundermanCodingTask.WebApplication.Models;

namespace WundermanCodingTask.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGizmoResource _gizmoResource;

        public HomeController(IGizmoResource gizmoResource)
        {
            _gizmoResource = gizmoResource;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _gizmoResource.Fetch());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
