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
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ParishionerModel parishionerModel)
        {
            if (ModelState.IsValid)
                return View("Result",parishionerModel);
            else
                return View();            
        }
        public ActionResult Edit(ParishionerModel parishioner)
        {
            return View(model:parishioner);
        }
        
    }
}
