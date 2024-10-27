using LibraryManagementApi.Communication.Request;
using LibraryManagementApi.Communication.Response;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<Book>()
        {
            new Book { Id = 1, Title = "Jogos Vorazes", Author = "Suzanne Collins", Genre = "ficção", Price = 199.99, Quantity = 10 },
            new Book { Id = 2, Title = "O Código Da Vinci", Author = "Dan Brown", Genre = "mistério", Price = 150.00, Quantity = 5 },
            new Book { Id = 3, Title = "Dom Quixote", Author = "Miguel de Cervantes", Genre = "clássico", Price = 120.00, Quantity = 8 },
        };
        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreatededBook), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestBookJson request)
    {
        var response = new ResponseCreatededBook
        {
            Title = request.Title,
        };
        return Created(string.Empty, response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody] RequestBookJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id)
    {
        return NoContent();
    }
}
