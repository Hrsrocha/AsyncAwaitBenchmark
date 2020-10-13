using System.Threading.Tasks;
using BenchTestApp;
using Microsoft.AspNetCore.Mvc;

namespace BenchApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BenchController : ControllerBase
    {
        private readonly Application app = new Application();

        [HttpGet]
        [Route("Get")]
        public int Get()
        {
            return app.ObterId();
        }

        [HttpGet]
        [Route("GetAsync")]
        public Task<int> GetAsync()
        {
            return app.ObterAsync();
        }

        [HttpGet]
        [Route("GetAsyncComAwait")]
        public async Task<int> GetAsyncComAwait()
        {
            return await app.ObterAsyncComAwait();
        }
    }
}
