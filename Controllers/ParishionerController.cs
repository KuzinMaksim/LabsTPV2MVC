using LabsTPV2._3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabsTPV2._3.Controllers
{
    public class ParishionerController : Controller
    {
        public short count = 0;
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ParishionerModel parishionerModel)
        {
            Request.Cookies.TryGetValue("count", out string countFromCookies);
            if (!Request.Cookies.ContainsKey("count"))
                Response.Cookies.Append("count", "1");


            if (ModelState.IsValid)
            {
                switch (countFromCookies)
                {
                    case null:
                        UserListStorage.parishionerModels[0] = parishionerModel;
                        break;
                    case "1":
                        UserListStorage.parishionerModels[1] = parishionerModel;
                        ViewBag.Parishioner = new ParishionerModel[2];
                        ViewBag.Parishioner = UserListStorage.parishionerModels;
                        return View("Result", parishionerModel);
                    default:
                        break;
                }
            }           
                return View(); 
            
        }
        public ActionResult Edit(ParishionerModel parishioner)
        {
            return View(model:parishioner);
        }
        
    }
}
