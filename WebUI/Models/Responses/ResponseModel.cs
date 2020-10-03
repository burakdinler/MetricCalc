using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models.Responses
{
    public class ResponseModel
    {
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string qualifier { get; set; }
        public Measures measures { get; set; }
    }
}