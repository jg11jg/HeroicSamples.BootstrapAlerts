using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HeroicSamples.BootstrapAlerts.Extensions
{
    public static class PageModelExtensions
    {
        public static PageModel WithSuccess(this PageModel pageModel, string title, string body)
        {
            return pageModel.WithAlert("success", title, body);
        }

        public static PageModel WithWarning(this PageModel pageModel, string title, string body)
        {
            return pageModel.WithAlert("warning", title, body);
        }

        public static PageModel WithDanger(this PageModel pageModel, string title, string body)
        {
            return pageModel.WithAlert("danger", title, body);
        }

        private static PageModel WithAlert(this PageModel pageModel, string type, string title, string body)
        {
            var tempData = pageModel.TempData;

            tempData["_alert.type"] = type;
            tempData["_alert.title"] = title;
            tempData["_alert.body"] = body;

            return pageModel;
        }
    }
}
