using System.Web;
using System.Web.Optimization;

namespace QuestReportingApp
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/Content/basestyle").Include(
               "~/Content/css/bootstrap.css",
               "~/Content/css/metisMenu.css",
               "~/Content/css/sb-admin-2.css",
               "~/Content/css/material.css",
               "~/Content/css/ripples.css",
               "~/Content/css/roboto.css",
               "~/Content/css/font-awesome.css"
            ));

            /*
            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
           */


            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                         "~/Scripts/jquery-{version}.js"));
            /*
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));
            */

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/base").Include(
                "~/Content/js/lib/jquery-2.1.4.min.js",
                "~/Content/js/lib/bootstrap.min.js",
                "~/Content/js/lib/material.min.js",
                "~/Content/js/lib/ripples.min.js",
                "~/Content/js/lib/angular.min.js",
                "~/Content/js/lib/angular-route.min.js",
                "~/Content/js/lib/angular-resource.min.js",
                "~/Content/js/qrApp.js"
            ));

            #if DEBUG
                BundleTable.EnableOptimizations = false;
            #else
                BundleTable.EnableOptimizations = true;
            #endif

        }
    }
}