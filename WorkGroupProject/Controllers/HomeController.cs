using System.Collections.Generic;
using System.Web.Http;

namespace WorkGroupProject.Controllers
{
    public class HomeController : ApiController
    {
        // GET: api/Test

        [HttpGet]
        public IHttpActionResult Menu()
        {
            var menues = new List<WorkGroupProject.Models.Menu>()
            {
                new WorkGroupProject.Models.Menu()
                {
                    Id = 1,
                    Title = "Test",
                    Children = new List<WorkGroupProject.Models.Menu>()
                    {
                        new WorkGroupProject.Models.Menu()
                        {
                            Id=100,
                            Title = "Test100"
                        }
                    }
                },
                new WorkGroupProject.Models.Menu()
                {
                    Id = 2,
                    Title = "Test2",
                    Children = new List<WorkGroupProject.Models.Menu>()
                    {
                        new WorkGroupProject.Models.Menu()
                        {
                            Id=200,
                            Title = "Test200"
                        }
                    }
                }
            };

            return Ok(menues);
        }
    }
}
