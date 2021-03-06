using System.Web;
using System.Web.Optimization;

namespace JqueryFormValidator
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.js",
                        "~/Scripts/jquery.validate.unobtrusive.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            // JQuery validator. 
            bundles.Add(new ScriptBundle("~/bundles/custom-validator").Include(
                                  "~/Scripts/script-custom-validator.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/mvcfoolproof").Include(
            "~/Client Scripts/mvcfoolproof.unobtrusive.js",
            "~/Client Scripts/mvcfoolproof.unobtrusive.min.js",
            "~/Client Scripts/MvcFoolproofJQueryValidation.js",
            "~/Client Scripts/MvcFoolproofJQueryValidation.min.js",
            "~/Client Scripts/MvcFoolproofValidation.js",
            "~/Client Scripts/MvcFoolproofValidation.min.js"));
        }
    }
}
