using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WannaEat.Web.ViewModels
{
    public class HomeViewModel
    {
        public List<Sales> Saleses { get; set; }

        public List<Member> Members { get; set; }
    }
}