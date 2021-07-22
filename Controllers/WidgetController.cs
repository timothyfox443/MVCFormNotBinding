using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCFormNotBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFormNotBinding.Controllers
{
    public class WidgetController : Controller
    {
        [HttpGet]
        public IActionResult AddNoBind()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNoBind(IFormCollection form)
        {
            Widget product = new Widget()
            {
                objName = form["product-name"],
                objDesc = form["product-description"],
                objWeight = Convert.ToDouble(form["unit-weight"]),
                objUnitCost = Convert.ToDouble(form["unit-cost"]),
                objSalePrice = Convert.ToDouble(form["unit-price"])
            };

            //add code here to insert object into DB that isn't created

            //oh and make the DB

            ViewData["isAddedNoBind"] = $"{product.objName} has been created and added to the, oh wait nevermind.";

            return View();
        }

        [HttpGet]
        public IActionResult AddWithBind()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddWithBind(Widget product)
        {
            if (ModelState.IsValid)
            {
                ViewData["isAddedYesBind"] = $"{product.objName} has been created and added to the, oh wait nevermind.";
            }
            return View();
        }


    }
}
