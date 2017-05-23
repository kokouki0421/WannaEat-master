using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WannaEat.Web.ViewModels;

namespace WannaEat.Web.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 顯示首頁
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                Saleses = new List<Sales>
                {
                    new Sales {Name = "Sophia", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum id dictum tellus. ", Url = "/Sales/1"},
                    new Sales {Name = "Emma", Description = "Vivamus vel massa egestas, eleifend turpis faucibus, finibus purus.", Url = "/Sales/2"},
                    new Sales {Name = "Olivia", Description = "Mauris venenatis ac nisi nec hendrerit. In lobortis massa sollicitudin, dictum nisi posuere, fermentum neque.", Url = "/Sales/3"},
                    new Sales {Name = "Isabella", Description = "Morbi vitae neque a tellus porttitor accumsan. Cras vulputate odio id ex lobortis bibendum.", Url = "/Sales/4"},
                    new Sales {Name = "Ava", Description = "Nulla facilisi. Curabitur vitae ante ac urna consectetur hendrerit.", Url = "/Sales/5"},
                    new Sales {Name = "Mia", Description = "Curabitur sollicitudin orci ac urna gravida placerat. Cras aliquet mollis accumsan.", Url = "/Sales/6"},
                    new Sales {Name = "Emily", Description = "Etiam porttitor et lectus et porttitor. Ut non nunc diam.", Url = "/Sales/7"},
                    new Sales {Name = "Abigail", Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.", Url = "/Sales/8"},
                    new Sales {Name = "Madison", Description = "Ut aliquam lacus ipsum, in lobortis massa elementum vel. Praesent quis consequat nisl.", Url = "/Sales/9"},
                    new Sales {Name = "Elizabeth", Description = "Vestibulum rhoncus massa elit, vel mattis ipsum bibendum maximus.", Url = "/Sales/10"},
                    new Sales {Name = "Charlotte", Description = "On tristique consectetur tincidunt. Duis eros sapien, elementum vel magna vitae, pharetra tincidunt turpis.", Url = "/Sales/11"},
                    new Sales {Name = "Avery", Description = "Etiam maximus aliquam turpis, sit amet ultrices mi varius at.", Url = "/Sales/12"},
                    new Sales {Name = "Sofia", Description = "Donec molestie, nibh sed suscipit interdum, lectus massa cursus arcu, sodales rutrum dui dui vel odio.", Url = "/Sales/13"},
                    new Sales {Name = "Chloe", Description = "In viverra luctus vestibulum. Integer rhoncus ullamcorper vehicula.", Url = "/Sales/14"},
                    new Sales {Name = "Ella", Description = "Cras tempor ipsum in faucibus pretium. Aenean tincidunt metus a lobortis porttitor.", Url = "/Sales/15"},
                    new Sales {Name = "Harper", Description = "Interdum et malesuada fames ac ante ipsum primis in faucibus.", Url = "/Sales/16"},
                    new Sales {Name = "Amelia", Description = "Nullam fermentum turpis quis commodo viverra.", Url = "/Sales/17"},
                    new Sales {Name = "Aubrey", Description = "Duis euismod non arcu eget suscipit. Nam volutpat enim felis, et elementum sapien consectetur eget.", Url = "/Sales/18"},
                    new Sales {Name = "Addison", Description = "Nunc sodales orci lacus, ut sodales turpis pellentesque eget.", Url = "/Sales/19"},
                    new Sales {Name = "Evelyn", Description = "Etiam elit tellus, euismod ut auctor sit amet, pulvinar non erat. Nullam luctus ex quam, nec rutrum arcu laoreet sed.", Url = "/Sales/20"}
                },
                Members = new List<Member>
                {
                    new Member { Email="gQ6uxbGV@gmail.com", Name="Bella", Password="9ErNFGn2"},
                    new Member { Email="TkXYVPZf@gmail.com", Name="Taylor", Password="KGSCZA5y"},
                    new Member { Email="2NyDXURf@gmail.com", Name="Alexa", Password="VKTSee6Z"},
                    new Member { Email="kzHx7Hcw@gmail.com", Name="Kylie", Password="Uqs49smp"},
                    new Member { Email="XaU3qtFH@gmail.com", Name="Mackenzie", Password="AcddHV77"},
                    new Member { Email="vQ72g76K@gmail.com", Name="Caroline", Password="MSNmP8Ym"},
                    new Member { Email="DfCmPmcu@gmail.com", Name="Kennedy", Password="U65DzpC9"},
                    new Member { Email="SDAxEmCP@gmail.com", Name="Autumn", Password="7yVvUy2d"},
                    new Member { Email="T75FKvKt@gmail.com", Name="Lucy", Password="pG8ZUmxv"},
                    new Member { Email="tBUEgQBM@gmail.com", Name="Ashley", Password="W4twWsnv"},
                    new Member { Email="BNA3fsVf@gmail.com", Name="Madelyn", Password="cnfSqMFv"},
                    new Member { Email="5AqrYxVa@gmail.com", Name="Violet", Password="F6pFAcZ5"},
                    new Member { Email="TRWTeQFd@gmail.com", Name="Stella", Password="XE7bmrD9"},
                    new Member { Email="CeUCymqt@gmail.com", Name="Brianna", Password="wfRFk2Un"},
                    new Member { Email="qRXhXhdk@gmail.com", Name="Maya", Password="5rtnRBdd"},
                    new Member { Email="UkXDSrg2@gmail.com", Name="Skylar", Password="m2x7gNV6"},
                    new Member { Email="A4rZKaCh@gmail.com", Name="Ellie", Password="gmCgwf4Q"},
                    new Member { Email="Y82yUNnK@gmail.com", Name="Julia", Password="WSpU9kSz"},
                    new Member { Email="Mv2QfCFM@gmail.com", Name="Sophie", Password="WG5gQYrT"},
                    new Member { Email="HTUEkyZ5@gmail.com", Name="Katherine", Password="wfPtCr6A"}
                }
            };
            return View(viewModel);
        }
        /// <summary>
        /// 處理使用者登入
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }
        /// <summary>
        /// 處理使用者登出
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout()
        {
            return View();
        }
        /// <summary>
        /// 處理使用者重設密碼(忘記密碼時)
        /// </summary>
        /// <returns></returns>
        public ActionResult Reset()
        {
            return View();
        }
        /// <summary>
        /// 處理使用者註冊帳號
        /// </summary>
        /// <returns></returns>
        public ActionResult Registered()
        {
            return View();
        }
        /// <summary>
        /// 顯示所有攤販列表
        /// </summary>
        /// <returns></returns>
        public ActionResult ShowAllSales()
        {
            return View();
        }
        /// <summary>
        /// 顯示使用者收藏之所有攤販
        /// </summary>
        /// <returns></returns>
        public ActionResult MyCollection()
        {
            return View();
        }
        /// <summary>
        /// 顯示更詳細的促銷訊息
        /// </summary>
        /// <returns></returns>
        public ActionResult SaleMessageDetail()
        {
            return View();
        }
    }
}