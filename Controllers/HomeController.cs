using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(int? id)
        {
            var movies = MovieRepository.Movies;
            if (id != null)
            {
                movies=movies.Where(i=>i.CategoryId==id).ToList();

            }

            // Modeli View'e gönderiyoruz
            return View(movies);
        }

        public IActionResult Details(int id)
        {
            // MovieCategoryModel model = new MovieCategoryModel()
            // {
            //     Categories = CategoryRepository.Categories,
            //     Movie = MovieRepository.GetById(id)
            // };

            return View(MovieRepository.GetById(id));
        }


        public IActionResult Contact()
        {
            return View();
        }
    }
}
