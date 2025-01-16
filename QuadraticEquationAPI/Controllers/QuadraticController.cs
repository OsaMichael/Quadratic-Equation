using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuadraticEquationAPI.Models;
using QuadraticEquationAPI.Repository;

namespace QuadraticEquationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuadraticController : ControllerBase
    {
        private readonly IQuadraticRepository _repository;
        public QuadraticController(IQuadraticRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("calculate")]
        public IActionResult calculate([FromBody] QuadraticModel input)
        {
            var result = _repository.SolveEquation(input);

            return Ok(result);
        }
    }
}
