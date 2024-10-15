using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Controllers
{
    public class MovieController:Controller
    {
        public IActionResult Index(){
            return View();
        }
        public IActionResult Create(){

            return View();
        }
        public IActionResult Details(){
            
            return View();
        }
        public IActionResult List(){
            
            return View();
        }
        
    }
}