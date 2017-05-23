using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WannaEat.Web.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        /// <summary>
        /// 顯示該攤販內頁
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}