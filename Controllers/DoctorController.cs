using Microsoft.AspNetCore.Mvc; 
using MvcApp.Models; 

namespace MvcApp.Controllers 
{
    
    public class DoctorController : Controller
    {
        //Define an action method for handling GET requests to CheckTemperature
        [HttpGet]
        public IActionResult CheckTemperature()
        {
            // eturn the view associated with this action
            return View();
        }
        // define action method for handling POST requests to 'CheckTemperature'
        [HttpPost]
        public IActionResult CheckTemperature(float temperature)
        {
            // Use the TemperatureChecker class to check the temperature and get a diagnosis
            string diagnosis = TemperatureChecker.CheckTemperature(temperature);

            // Pass the diagnosis message to the view using ViewBag
            ViewBag.Diagnosis = diagnosis;
            // Return the view associated with this action
            return View();
        }
    }
}