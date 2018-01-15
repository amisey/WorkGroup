using System.Web.Mvc;

namespace WorkGroupProject.Areas.Amir
{
    public class AmirAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Amir";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Amir",
                "Amir",
                new {controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Amir_default",
                "Amir/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}