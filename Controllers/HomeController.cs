using Microsoft.AspNetCore.Mvc;
using ScaffoldingTemplate.Models;

namespace ScaffoldingTemplate.Controllers
{
    public class HomeController : Controller
    {
        List<User> userList = new List<User>();
        public HomeController()
        {
            userList.Add(new User { UserId = "1", UserName = "eyildirim", Password = "123", Name = "Ekrem", SurName = "Yıldırım" });
            userList.Add(new User { UserId = "2", UserName = "bgenc", Password = "321", Name = "Büşra", SurName = "Genç" });
            userList.Add(new User { UserId = "3", UserName = "oderman", Password = "213", Name = "Onur", SurName = "Derman" });
        }

        //Action name sağ tık yapıp addview diyebilirsiniz. 
        public IActionResult Index()
        {
            return View(userList);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User model)
        {
            return View();
        }

        public IActionResult Edit(string id)
        {
            var model = userList.FirstOrDefault(c => c.UserId == id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(User model)
        {
            return View();
        }
    }
}
