using CutomilyNetCoreTest.Models;
using CutomilyNetCoreTest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CutomilyNetCoreTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Page : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromServices] IPageService pageService, [FromBody] PageViewModel value)
        {
            pageService.SavePage(value);

            return Ok();
        }

        [HttpGet]
        public List<string> GetTitelsByxy([FromServices] IPageService pageService, double x, double y)
        {
            return pageService.GetTitlesByxy(x, y);
        }
    }
}
