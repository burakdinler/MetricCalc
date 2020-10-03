using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebUI.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            string jqureyCdn = "https://code.jquery.com/jquery-3.5.1.slim.min.js";
            string popperCdn = "https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js";
            string bootstrapCdn = "https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css";
            string bootstrapJsCdn = "https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js";

            bundles.Add(new ScriptBundle("~/bundles/jquery", jqureyCdn).Include("~/Scripts/jquery-{version}.js"));     
            bundles.Add(new ScriptBundle("~/bundles/popper", popperCdn).Include("~/Scripts/popper.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap", bootstrapJsCdn).Include("~/Scripts/bootstrap.js"));
            bundles.Add(new StyleBundle("~/bundles/css", bootstrapCdn).Include("~/Content/bootstrap.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}