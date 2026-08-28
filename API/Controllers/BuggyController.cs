
using API.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        [HttpGet("unauthorized")]
        public IActionResult GetUnauthorised()
        {
            return Unauthorized(); // 401 Unauthorized
        }

        [HttpGet("badrequest")]
        public IActionResult GetBadRequest()
        {
            return BadRequest("Not a good request"); // 400 Bad Request
        }

        [HttpGet("notfound")]
        public IActionResult GetNotFound()
        {
            return NotFound(); // 404 Not Found
        }

        [HttpGet("internalerror")]
        public IActionResult GetInternalError()
        {
            throw new Exception("This is a test exception");
        }

        [HttpGet("validationerror")]
        public IActionResult GetValidationError(CreateProductDto product)
        {
            return Ok(); // 401 Unauthorized
        }
    }
}
