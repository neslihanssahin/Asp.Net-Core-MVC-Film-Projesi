using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;

namespace MovieApp.ViewComponents
{
    public class CategoryMenuViewComponent : ViewComponent
    {

        //{controller}/{action}/{id?} bizim varsayılan route bu şekilde
        //mesela /home/index/3
        //RouteData.Values["controller"]=>home
        //RouteData.Values["action"]=>index
        //RouteData.Values["id"]=>3





        public IViewComponentResult Invoke()
        {

            if (RouteData.Values["action"].ToString() == "Index")
                ViewBag.SelectedCategory = RouteData?.Values["id"];
            return View(CategoryRepository.Categories);
        }
    }
}