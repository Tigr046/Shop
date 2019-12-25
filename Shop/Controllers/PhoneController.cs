using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.DBContext;

namespace Shop.Controllers
{
    public class PhoneController : Controller
    {
        ApplicationContext _applicationContext;
        public PhoneController(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public IActionResult Index()
        {
            return View(_applicationContext.Phones.ToList());
        }
        public ActionResult Product(Guid id)
        {
            return View(_applicationContext.Phones.Find(id));
        }
    }
}