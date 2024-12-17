using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;
using WebApplication4.Repositories.Interfaces;

namespace WebApplication4.Controllers
{
    [Route("api/eredmenyek")]
    [ApiController]
    public class EredmenyekController : ControllerBase
    {
        private readonly EredmenyekInterface eredmenyekInterface;

        public EredmenyekController(EredmenyekInterface eredmenyekInterface)
        {
            this.eredmenyekInterface = eredmenyekInterface;
        }

        public async Task<ActionResult> PostNewResult(Eredmenyek eredmenyek)
        {
            var eredmeny = await eredmenyekInterface.NewResult(eredmenyek);

            if (eredmeny != null)
            {
                return Ok(new { result= eredmeny ,  message = "Sikeres feltoltes"});
            }
            Exception e = new();
            return BadRequest(new {result=eredmeny,e.Message });
        }
    }
}
