using System.Web.Mvc;

namespace WorkGroupProject.Areas.Majid
{
    public class MajidAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Majid";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Majid",
                "Majid",
                new {controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Majid_default",
                "Majid/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}