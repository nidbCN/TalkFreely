using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TalkFreely.Backend.Controllers;

[ApiController]
[Route("api/sites/{siteId:Guid}/pages")]
public class PagesController : ControllerBase
{
    private readonly ILogger<PagesController> _logger;

    public PagesController(ILogger<PagesController> logger)
    {
        _logger = logger
            ?? throw new ArgumentNullException(nameof(logger));
    }
    

}
