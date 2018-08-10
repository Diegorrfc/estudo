using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tigre.Models;
using Tigre.Repository;
using Tigre.ViewModel;

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


            //IBotViewModelRepository _casa;
            //_casa = new BotViewModelRepositorio();
             Bot diego = new Bot() { BotId=1, BotNome = "f" };
            _botRepositorio = new BotRepository();
            var a = _botRepositorio.GetAllEntity();
            List<BotViewModel> ListabotVM = new List<BotViewModel>();
            foreach (var item in a)
            {
                BotViewModel botvm = new BotViewModel
                {
                    BotId = item.BotId
                };
                ListabotVM.Add(botvm);
            }
            // _botRepositorio.Insert(diego);
            //_botRepositorio.Save();
            // _botRepositorio.Update()
            // _botRepositorio.Update(diego);
            // _botRepositorio.Save();
            // var g= _botRepositorio.GetEntityByID(1);
            // _botRepositorio.Delete(n => n.BotId == diego.BotId);
            // _botRepositorio.Save();



            //Database.SqlQuery<Bot>("exec GetCoursesByStudentId").ToList<Bot>();

            //var b = _botRepositorio.GetAllEntity();          

            return View();
        }
    }
}
