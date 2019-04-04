﻿using System.Web.Optimization;

namespace MVC_CRUDE_API_TASK2
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            


            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                       "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                     "~/Scripts/bootbox.js",
                     "~/Scripts/datatables/jquery.datatables.js",
                     "~/Scripts/dataTables/datatables.bootstrap.js",
                     "~/Scripts/dataTables/datetime.js",
                     "~/Scripts/moment.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));


            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate.js",
            //            "~/Scripts/jquery.validate.unobtrusive.js",
            //            "~/Scripts/jquery.unobtrusive-ajax.js"));





            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                       "~/content/dataTables/css/datatables.bootstrap.css",
                       "~/Content/site.css"));
        }
    }
}
