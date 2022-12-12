using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace GiftingAPI.Controllers;


public class PeopleController : ControllerBase
{
    //GET /people
     [HttpGet("/people")]

    public async Task<ActionResult<PersonResponse>> GetAllPeople()
    {
        var people = new List<PersonItemResponse>() {
    new PersonItemResponse("1", "Bill", "Hulley"),
    new PersonItemResponse("2", "Sarah", "Iozzi")
    };
        var response = new PersonResponse(people);
        return Ok(response);
    }


}
