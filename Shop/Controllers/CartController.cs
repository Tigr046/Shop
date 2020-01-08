using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.DBContext;
using Shop.Helper;
using Shop.Models;

namespace Shop.Controllers
{
    public class CartController : Controller
    {
        private ApplicationContext db = new ApplicationContext();

        public IActionResult Index(CartModel cartModel)
        {
            var cart = SessionHelper.GetObjectFromJson<List<PhoneItem>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            if (cart != null)
                foreach (var i in cart)
                {
                    cartModel.Count += i.Quantity;
                    cartModel.TotalPrice += i.Quantity * i.Phone.Price;
                }
            return View(cartModel);
        }

        public IActionResult Buy(Guid id)
        {
            if (SessionHelper.GetObjectFromJson<List<PhoneItem>>(HttpContext.Session, "cart") == null)
            {
                var cart = new List<PhoneItem>();
                cart.Add(new PhoneItem()
                {
                    Phone = db.Phones.Find(id),
                    Quantity = 1
                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                var cart = SessionHelper.GetObjectFromJson<List<PhoneItem>>(HttpContext.Session, "cart");
                int index = Exists(cart, id);
                if (index == -1)
                {
                    cart.Add(new PhoneItem()
                    {
                        Phone = db.Phones.Find(id),
                        Quantity = 1
                    });
                }
                else
                {
                    cart[index].Quantity++;
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

            }
            return RedirectToAction("Index");
        }
        private int Exists(List<PhoneItem> cart, Guid id)
        {
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Phone.Id == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}