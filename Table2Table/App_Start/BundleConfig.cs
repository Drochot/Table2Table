using System.Web;
using System.Web.Optimization;

namespace Table2Table
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/materialize").Include(
                        "~/Scripts/materialize.js",
                        "~/Scripts/materialize.min.js",
                        "~/Scripts/materialize.settings.js"));

            bundles.Add(new StyleBundle("~/Content/materialize").Include(
                      "~/Content/materialize.css",
                      "~/Content/materialize.min.css",
                      "~/Content/materialize.custom.css"));
        }
    }
}
