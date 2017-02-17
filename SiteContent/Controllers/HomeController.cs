using System.Threading;
using System.Web.Mvc;
using SiteProject.Infrastructure;
using SiteProject.Infrastructure.Models;

namespace SiteContent.Controllers
{
    public class HomeController : Controller
    {
        Context ctx = new Context();
        // GET: Home
        public ActionResult Index()
        {
            ctx.Tags.Add(new Tag() {Title = "chan"});
            return View();
        }
    }
}