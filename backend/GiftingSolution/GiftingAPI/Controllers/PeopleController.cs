

using GiftingAPI.Domain;
using GiftingAPI.Models;

namespace GiftingApi.Controllers;

[ApiController]
public class PeopleController : ControllerBase
{

    private readonly ICatalogPeople _personCatalog;
    private readonly ILogger<PeopleController> _logger;

    public PeopleController(ICatalogPeople personCatalog)
    {
        _personCatalog = personCatalog;
    }

    [HttpGet("/people/{id:int}")]
    public async Task<ActionResult<PersonItemResponse?>> GetPersonById(int id)
    {
        PersonItemResponse response = await _personCatalog.GetPersonByIdAsync(id);
        if (response is null)
        {
            return NotFound();
        }
        else
        {
            return Ok(response);
        }
    }

    [HttpPost("/people")]

    public async Task<ActionResult<PersonItemResponse>> AddPerson([FromBody] PersonCreateRequest request)
    {
        // Validate request
        // If valid add to database send 201, if not send 400 (bad rewquest)

        PersonItemResponse response = await _personCatalog.AddPersonAsync(request);
        return StatusCode(201, response);
    }


    // GET /people
    [HttpGet("/people")]
    public async Task<ActionResult<PersonResponse>> GetAllPeople(CancellationToken token)
    {
        _logger.LogInformation("Get a request to get somse people... ");
        await Task.Delay(3000);
        PersonResponse response = await _personCatalog.GetPeopleAsync(token);
        _logger.LogInformation($"Got some people from the DB {response.Data.Count} persons ");
        return Ok(response);
    }
}