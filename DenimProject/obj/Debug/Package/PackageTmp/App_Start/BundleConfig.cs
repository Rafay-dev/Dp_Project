using System.Web;
using System.Web.Optimization;

namespace DenimProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));


            bundles.Add(new ScriptBundle("~/bundles/layout_scripts").Include(
                        "~/assets/js/scrollup/jquery.scrollUp.js",
                        "~/assets/js/bsvalidator/bootstrapValidator.js",
                        "~/assets/js/bsvalidator/custom-validations.js",
                        "~/assets/js/user.js",
                        "~/assets/js/sparkline/sparkline.js",
                        "~/assets/js/sparkline/custom-sparkline.js",
                        "~/assets/js/datatables/dataTables.min.js",
                        "~/assets/js/datatables/dataTables.bootstrap.min.js",
                        "~/assets/js/datatables/autoFill.min.js",
                        "~/assets/js/datatables/autoFill.bootstrap.min.js",
                        "~/assets/js/datatables/fixedHeader.min.js",
                        "~/assets/js/datatables/custom-datatables.js",
                        "~/assets/js/custom.js",
                        "~/assets/js/sweetalert.min.js")); 

            bundles.Add(new StyleBundle("~/Content/layout_css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/font-awesome.css",
                      "~/assets/css/main.css",
                      "~/assets/css/user.css",
                      "~/assets/fonts/icomoon/icomoon.css",
                      "~/assets/css/datatables/dataTables.bs.min.css",
                      "~/assets/css/datatables/autoFill.bs.min.css",
                      "~/assets/css/datatables/fixedHeader.bs.min.css"
                      ));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));
        }
    }
}
