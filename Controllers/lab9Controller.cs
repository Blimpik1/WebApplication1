using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class lab9Controller : Controller
    {
        public ActionResult Firstviewmethod() {
            List<string> fruits = GetFruitsList();
            return View(fruits);
        }
        public ActionResult Secondviewmethod() { 
            return View(GetFruitsList().OrderBy(x=>x).ToList());
        }
        public ActionResult Thirdviewmethod()
        {
            return View(GetFruitsList().OrderBy(x => x).ToList());
        }
        public List<string> GetFruitsList()
        {
            List<string> fruits = new List<string>();
            fruits.Add("Яблуко");
            fruits.Add("Ягода");
            fruits.Add("Банан");
            fruits.Add("Баклажан");
            fruits.Add("Апельсин");
            fruits.Add("Груша");
            fruits.Add("Виноград");
            fruits.Add("Персик");
            fruits.Add("Ківі");

            return fruits;
        }

    }
}