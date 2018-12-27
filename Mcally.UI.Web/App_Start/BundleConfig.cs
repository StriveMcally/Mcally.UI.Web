using System.Web;
using System.Web.Optimization;

namespace Mcally.UI.Web
{
    public class BundleConfig
    {
        // 有关捆绑的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/css/bootstrap.min.css",
                     "~/Content/css/style.css",
                     "~/Content/css/login.min.css",
                     "~/Content/ruoyi/css/ry-ui.css",
                     "~/Content/css/font-awesome.min.css"
                    ));
        
            bundles.Add(new ScriptBundle("~/bundles/Scripts1").Include(
                        "~/Scripts/js/bootstrap.min.js",
                        "~/Scripts/ajax/libs/validate/jquery.validate.min.js",
                        "~/Scripts/ajax/libs/layer/layer.min.js",
                        "~/Scripts/ajax/libs/validate/messages_zh.min.js",
                        "~/Scripts/ajax/libs/blockUI/jquery.blockUI.js",
                        "~/Scripts/ruoyi/js/ry-ui.js",
                        "~/Scripts/ruoyi/login.js"
                        
                        ));

            bundles.Add(new ScriptBundle("~/bundles/Scripts").Include(
                      "~/Scripts/js/jquery.min.js"
                     

                      ));





        }

    }
}
