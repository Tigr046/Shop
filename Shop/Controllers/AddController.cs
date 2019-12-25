using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.DBContext;
using Shop.Models;

namespace Shop.Controllers
{
    public class AddController : Controller
    {
        ApplicationContext ApplicationContext { get; set; }
        public AddController(ApplicationContext applicationContext)
        {
            ApplicationContext = applicationContext;
        }
        public ActionResult AddPhone()
        {
            var CarView = GetPhoneViewModel();
            return View(CarView);
        }
        [HttpPost]
        public ActionResult AddPhone(Phone phone)
        {

            ApplicationContext.Phones.Add(phone);
            ApplicationContext.SaveChanges();
            return View(GetPhoneViewModel());
        }
        private PhoneViewModel GetPhoneViewModel(Phone phone = null) => new PhoneViewModel
        {

            Phone = phone ?? new Phone()
        };
    }
}