using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Fresher.CukCuk.VuVanSon.Model;

namespace MISA.Fresher.CukCuk.VuVanSon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName(string? name, string? code)
        {
            return Ok(name);
        }
        [HttpPost]
        public IActionResult PostCustomer([FromBody] Customer customer)
        {
            return Ok(customer);
        }
        [HttpPut]
        public IActionResult PUT(Customer customer)
        {
            return Ok(customer);
        }
        [HttpDelete("id")]
        public IActionResult delete (Customer customer)
        {
            return Ok(customer);
        }
    }
}
