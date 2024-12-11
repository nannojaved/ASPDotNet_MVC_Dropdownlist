using Microsoft.AspNetCore.Mvc;

namespace ASPDotNet_MVC_Dropdownlist.Controllers
{
    public class DropdownController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        

        public IActionResult InlineInView()
        {
            return View();
        }

        static void ShowSelectedItem()
        {

        }
    }
}
