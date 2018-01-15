using System.Web.Mvc;

namespace WorkGroupProject.Areas.Mohamad
{
    public class MohamadAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Mohamad";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Mohamad",
                "Mohamad",
                new {controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Mohamad_default",
                "Mohamad/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}