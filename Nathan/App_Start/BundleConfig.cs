namespace Nathan.App_Start
{
    using System.Web.Optimization;

    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/Less.site.less"));

            bundles.Add(new ScriptBundle("~/Scripts").Include(
                "~/Scripts/jquery-{version}.js"));
        }
    }
}