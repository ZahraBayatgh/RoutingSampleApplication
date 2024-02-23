using Microsoft.AspNetCore.Mvc;
using RoutingSampleApplication.Services;


namespace RoutingSampleApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetCustomerById(int id)
        {
            var result = _customerService.GetById(id);
            return Ok(result);
        }

        [HttpGet("{email}")]
        public IActionResult GetCustomerByEmail(string email)
        {
            var result = _customerService.GetByEmail(email);
            return Ok(result);
        }


    }
}
