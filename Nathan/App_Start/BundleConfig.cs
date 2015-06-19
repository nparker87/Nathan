namespace Nathan.App_Start
{
    using System.Web.Optimization;

    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // BundleTable.EnableOptimizations = true;

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/Less/Site.less"));

            bundles.Add(new ScriptBundle("~/Scripts").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/TextBoxHelper.js",
                "~/Scripts/Site.js"));
        }
    }
}