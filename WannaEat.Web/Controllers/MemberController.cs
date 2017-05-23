using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WannaEat.Web.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        /// <summary>
        /// 顯示個人資料
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 顯示常見Q&A
        /// </summary>
        /// <returns></returns>
        public ActionResult FAQ()
        {
            return View();
        }
        /// <summary>
        /// 顯示聯絡我們
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact()
        {
            return View();
        }
    }
}