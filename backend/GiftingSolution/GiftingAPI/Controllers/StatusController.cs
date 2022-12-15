using GiftingApi.Adapters;
using GiftingApi.Models;

namespace GiftingAPI.Controllers;

public class StatusController : ControllerBase
{
    private readonly OnCallLookupApiAdapter _api;

    [HttpGet("/status")]
    public async Task<ActionResult> GetApiStatus()
    {

        return Ok();
    }
}

public record StatusResponse(string Status, DateTime LastChecked, OnCallDeveloperResponse onCallDeveloper);