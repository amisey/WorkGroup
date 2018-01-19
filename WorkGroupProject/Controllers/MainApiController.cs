using System.Collections.Generic;
using System.Web.Http;

namespace WorkGroupProject.Controllers
{
    public class MainApiController : ApiController
    {
        // GET: api/Test

        [HttpGet]
        public IHttpActionResult Menu()
        {
            return Ok(GetMenues());
        }

        private IEnumerable<Models.Menu> GetMenues()
        {
            return new List<Models.Menu>()
            {
                new Models.Menu()
                {
                    Id = 1,
                    Title = "Home"
                },
                new Models.Menu()
                {
                    Id = 2,
                    Title = "Topics"
                },
                new Models.Menu()
                {
                    Id = 3,
                    Title = "About us",
                    Children = new List<Models.Menu>()
                    {
                        new Models.Menu()
                        {
                            Id = 200,
                            Title = "Avijeh"
                        }
                    }
                }
            };
        }
    }
}
