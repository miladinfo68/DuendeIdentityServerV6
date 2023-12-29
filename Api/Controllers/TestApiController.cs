using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Authorize("ApiScope")]
[Route("api/[controller]")]
public class TestApiController : ControllerBase
{
    [AllowAnonymous]
    [HttpGet(Name = "hc")]
    public string Hc() => "Api ok 200";

    [HttpGet(Name = "secret")]
    public string Secret() => "Secret Api ok 200";
}