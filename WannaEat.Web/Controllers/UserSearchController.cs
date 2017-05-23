using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WannaEat.Web.Controllers
{
    public class UserSearchController : Controller
    {
        // GET: UserSearch
        /// <summary>
        /// 顯示搜尋結果
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 處理使用者將攤販加入收藏
        /// </summary>
        /// <returns></returns>
        public ActionResult AddCollection()
        {
            return View();
        }
        /// <summary>
        /// 處理使用者將攤販從收藏移除
        /// </summary>
        /// <returns></returns>
        public ActionResult DeleteCollection()
        {
            return View();
        }

    }
}