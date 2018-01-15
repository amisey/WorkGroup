using System.Web.Mvc;

namespace WorkGroupProject.Areas.Zahra
{
    public class ZahraAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Zahra";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Zahra",
                "Zahra",
                new {controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Zahra_default",
                "Zahra/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}