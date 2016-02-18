using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using DataAccessLayer;
using ModelsLayer;

namespace HW5_WCFService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var EmpList = BusinessInformation.GetEmpData();
            return View(EmpList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var EmpList = BusinessInformation.GetEmpData();
            return View(EmpList);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var EmpList = BusinessInformation.GetEmpData();
            return View(EmpList);
        }
    }
}