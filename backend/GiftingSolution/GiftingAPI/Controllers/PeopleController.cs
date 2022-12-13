

using GiftingAPI.Domain;
using GiftingAPI.Models;

namespace GiftingApi.Controllers;

[ApiController]
public class PeopleController : ControllerBase
{

    private readonly ICatalogPeople _personCatalog;

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
    public async Task<ActionResult<PersonResponse>> GetAllPeople()
    {
        PersonResponse response = await _personCatalog.GetPeopleAsync();
        return Ok(response);
    }
}