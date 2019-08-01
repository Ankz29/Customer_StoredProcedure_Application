using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Customer_Application.Models;
using Customer_Application.CustomerUtility;

namespace Customer_Application.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Customer modelData)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CustomerUtilityClass.InsertData(modelData);
                }
                ModelState.Clear();
            }
            catch(Exception)
            {
                new Exception("Data could not be saved, please try again !!");
            }
            ViewBag.SuccessMessage = "Data saved scuccessfully !!";
            return View();
        }

       

    }
}
