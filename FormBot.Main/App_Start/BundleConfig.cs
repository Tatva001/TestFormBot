﻿using System.Web;
using System.Web.Optimization;

namespace FormBot.Main
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/jquery.js",
                      "~/Scripts/jquery.min.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/bootstrap-datepicker.js",
                      "~/Scripts/modernizr.js",
                      "~/Scripts/respond.min.js",
                      "~/Scripts/fastclick.min.js",
                      "~/Scripts/general.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/reset.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/datepicker.css",
                      "~/Content/style.css"));
        }
    }
}
