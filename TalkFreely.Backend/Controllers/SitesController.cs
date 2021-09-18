using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TalkFreely.Backend.Controllers
{
    [ApiController]
    [Route("api/sites")]
    public class SitesController : ControllerBase
    {
        private readonly ILogger<SitesController> _logger;

        public SitesController(ILogger<SitesController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public async IActionResult GetSiteList()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{siteId}")]
        public async IActionResult GetSiteAsync(Guid siteId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult CreateSite()
        {
            var siteId = new Guid();

            throw new NotImplementedException();
        }

        [HttpPut("{siteId}")]
        public IActionResult UpdateSite(Guid siteId)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{siteId}")]
        public IActionResult DeleteSite(Guid siteId)
        {
            throw new NotImplementedException();
        }
    }
}
