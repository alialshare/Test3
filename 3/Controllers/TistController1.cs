using Microsoft.AspNetCore.Mvc;

namespace _3.Controllers
{
    public class TistController1 : Controller
    {
      public string Hello()
      {
            return "hello first control";
      } 
        public IActionResult FirstPage()
        {

            return View();
        }
    }
}
