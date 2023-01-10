﻿using System.Web;
using System.Web.Optimization;

namespace EmployeeManagement
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/Kendo").Include(
                      "~/Content/kendo/2020.1.219/kendo.common.min.css",
                      "~/Content/kendo/2020.1.219/kendo.default.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                        "~/Scripts/kendo/2020.1.219/jquery.min.js",
                        "~/Scripts/kendo/2020.1.219/kendo.web.min.js",
                        "~/Scripts/kendo/2020.1.219/kendo.all.min.js",
                        "~/Scripts/kendo/2020.1.219/kendo.aspnetmvc.min.js"
                 ));
        }
    }
}
