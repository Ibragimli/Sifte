using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sifte.Model;

namespace Sifte.Controllers
{
    public class CarController : Controller
    {
        
        private List<Car> _car;
        public CarController()
        {
            _car = new List<Car>
            {
                new Car{Id =1,Name="E200",Brand = " Mercedes",Color = "Black"},
                new Car{Id =2,Name="E201",Brand = " Mercedes1",Color = "Red"},
                new Car{Id =3,Name="E202",Brand = " Mercedes2",Color = "Yellow"},
                new Car{Id =4,Name="E203",Brand = " Mercedes3",Color = "White"}

            };
        }

        public ActionResult Index()
        {
             ViewBag.Cars = _car;
            return View();

        }
        public ActionResult Detail(int id)
        {
            Car car1 = _car.Find(x => x.Id == id);
            ViewBag.Cars = car1;
            return View();
        }
    }
}
