using CustomilyNETTest.Models;
using CustomilyNETTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomilyNETTest.Controllers
{
    public class PagesController : ApiController
    {
        public System.Web.Http.Results.OkResult Post([FromBody] PageViewModel value)
        {
            var pageService = new PageService();
            pageService.SavePage(value);

            return Ok();
        }

        public List<string> GetTitelsByxy(double x, double y)
        {
            var pageService = new PageService();
            var r = pageService.GetTitlesByxy(x, y);

            return r;
        }
    }
}
