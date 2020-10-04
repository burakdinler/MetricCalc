using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUI.Models.Enums;

namespace WebUI.Models.PageModel
{
    public class HomeModel
    {
        public string Component { get; set; }
        public UrlType UrlType { get; set; }
    }
}