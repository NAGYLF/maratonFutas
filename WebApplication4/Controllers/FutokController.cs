using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Repositories.Interfaces;

namespace WebApplication4.Controllers
{
    [Route("api/runners")]
    [ApiController]
    public class FutokController : ControllerBase
    {
        private readonly FutokInterface futokInterface;

        public FutokController(FutokInterface futokInterface)
        {
            this.futokInterface = futokInterface;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllRunners()
        {
            var runners = await futokInterface.AllRunners();
            if (runners != null)
            {
                return Ok(new {result = runners, message = "Sikeres lekerdeszes" });
            }
            Exception e = new();
            return BadRequest(new { result = runners, message = e.Message});
        }
        [HttpGet("byId")]
        public async Task<ActionResult> GeById(int id)
        {
            var runners = await futokInterface.ById(id);
            if (runners != null)
            {
                return Ok(new { result = runners, message = "Sikeres lekerdeszes" });
            }
            Exception e = new();
            return BadRequest(new { result = runners, message = e.Message });
        }
        [HttpGet("RunnerWithAllData")]
        public async Task<ActionResult> GetRunnerWithAllData(int id)
        {
            var runners = await futokInterface.RunnerWithAllData(id);
            if (runners != null)
            {
                return Ok(new { result = runners, message = "Sikeres lekerdeszes" });
            }
            Exception e = new();
            return BadRequest(new { result = runners, message = e.Message });
        }
    }
}
