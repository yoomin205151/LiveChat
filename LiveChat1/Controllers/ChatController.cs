using Microsoft.AspNetCore.Mvc;

namespace LiveChat1.Controllers
{
    public class ChatController : Controller
    {

        public static Dictionary<int, string> Rooms =
            new Dictionary<int, string>()
            {
                {1,"Programacion" },
                {2,"Tests" },
                {3,"News" }
            };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Room(int room)
        {
            return View("Room", room);
        }
    }
}
