using Microsoft.AspNetCore.Mvc;

namespace BirthdayCalander.Controllers
{
    [ApiController]
    [Route("v1/birthday")]
    public class BirthdayController : ControllerBase
    {
        private readonly ILogger<BirthdayController> _logger;

        public BirthdayController(ILogger<BirthdayController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("addBirthday")]
        public IActionResult AddNewBirthday(string birthDate, string name)
        {
            if (name != null && name != string.Empty)
            {
                var birthday = new Birthday 
                {
                    BirthDate = DateOnly.Parse(birthDate),
                    Name = name,
                };
                return Ok();
            }
            return BadRequest("Name was not valid");
        }
    }
}