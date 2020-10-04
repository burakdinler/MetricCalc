using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Services.Description;
using WebUI.Models.Enums;
using WebUI.Models.Results;

namespace WebUI.Library
{
    public static class Operations
    {
        public static string ApiUrl(UrlType urlType)
        {
            string apiUrl = "";
            switch (urlType)
            {
                case UrlType.LOCAL:
                    apiUrl = "http://localhost:9000/api";
                    break;
                case UrlType.CLOUD:
                    apiUrl = "https://sonarcloud.io/api";
                    break;
                default:
                    break;
            }
            return apiUrl;
        }

        public static string UrlBuild(string baseUrl, string apiFunc,List<MetricKeys> metricKeys, string component)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(baseUrl);
            sb.Append(apiFunc);
            int keySize = metricKeys.Count;
            foreach (var key in metricKeys)
            {
                sb.Append(key.KeyName);
                if (keySize > 1)
                {
                    sb.Append(",");
                }
                keySize--;
            }
            sb.Append("&component=");
            sb.Append(component);

            return sb.ToString();
        }

        public static HttpWebRequest webRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            return request;
        }

        public static WebResponse webResponse(HttpWebRequest request)
        {
            WebResponse response = request.GetResponse();
            return response;
        }



    }
}