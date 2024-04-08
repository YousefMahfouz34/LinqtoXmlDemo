using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadAndWriteXml.Models;
using ReadAndWriteXml.Services;

namespace ReadAndWriteXml.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
       
        private readonly ICustomerServices customerServices;

        public CustomerController(ICustomerServices customerServices)
        {
            this.customerServices = customerServices;
        }

        [HttpPost]
        public async Task<IActionResult> Add(Customer customer)
        {
            var res = await customerServices.Write(customer);
            return Ok(res);
            
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var res = await customerServices.Read();
            return Ok(res);

        }
    }
}
