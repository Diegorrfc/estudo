using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tigre.Models;
using Tigre.Repository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tigre.Controllers
{
    [Route("[controller]/[action]")]
    public class BotController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            IBotRepository _botRepositorio;
            _botRepositorio = new BotRepository();
            var b = _botRepositorio.GetAllEntity();          
            
            return View();
        }
    }
}
