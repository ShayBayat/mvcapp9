using Microsoft.AspNetCore.Mvc; 

namespace MvcApp.Controllers 
{
   
    public class HomeController : Controller
    {
        // action method for handling requests to the 'About' page
        public IActionResult About()
        {
            // Setting titel 
            ViewData["Title"] = "About";
            
            return View();
        }

        //   action method for handling requests to the 'Contact' page
        public IActionResult Contact()
        {
            
            ViewData["Title"] = "Contact";
            
            // Return the view associated with this action
            return View();
        }

       
        public IActionResult Projects()
        {
           
            ViewData["Title"] = "Projects";
            
            
            return View();
        }
    }
}