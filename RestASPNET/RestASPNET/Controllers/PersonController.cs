using Microsoft.AspNetCore.Mvc;
using RestASPNET.DTO;
using RestASPNET.Service;

namespace RestASPNET.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    
    private readonly ILogger<PersonController> _logger;
    private readonly IPersonService _personService;

    public PersonController(ILogger<PersonController> logger, IPersonService personService)
    {
        _logger = logger;
        _personService = personService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_personService.FindAll());
    }
    [HttpGet("{id}")]
    public IActionResult GetById(long id)
    {
        var person = _personService.FindById(id);
        if (person == null)
        {
            return NotFound();
        }
        return Ok(person);
    }

    [HttpPost]
    public IActionResult Create([FromBody] PersonDTO personDto)
    {
        if (personDto == null) return BadRequest();
        return Ok(_personService.Create(personDto));
    }
    [HttpPut("{id}")]
    public IActionResult Update([FromBody] PersonDTO personDto, long id)
    {
        return Ok(_personService.Update(personDto, id));
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(long id)
    {
        _personService.Delete(id);
        return NoContent();
    }
    
    
    
    
}