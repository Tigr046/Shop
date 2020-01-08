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
    public class EditController : Controller
    {
        ApplicationContext applicationContext = new ApplicationContext();
        // GET: Edit
        public ActionResult PhoneEdit(Guid guid)
        {
            
            return View(applicationContext.Phones.Find(guid));
        }
        [HttpPost]
        public ActionResult PhoneEdit(Phone phone)
        {
            applicationContext.Phones.Remove(applicationContext.Phones.Find(phone.Id));
            applicationContext.Phones.Add(phone);
            applicationContext.SaveChanges();
            return View(phone);
        }
        public ActionResult PhoneDelete(Guid guid)
        {
            applicationContext.Phones.Remove(applicationContext.Phones.Find(guid));
            applicationContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Index()
        {
            return View(applicationContext.Phones.ToList());
        }
    }
}