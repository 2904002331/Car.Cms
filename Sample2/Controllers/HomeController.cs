using Microsoft.AspNetCore.Mvc;
using Sample2.Models;
using System.Diagnostics;

namespace Sample2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

       

        public IActionResult Index()

        {

            var contents = new List<Content>();
            for (int i = 0; i < 10; i++)
            {
                contents.Add(new Content { Id = i, title = $"{i} 标题" ,content=$"{i} 内容",status=1,add_time=DateTime.Now.AddDays(-i)});
            }

            return View(new ContentViewModel { Contents = contents });
        }

        
    }
}