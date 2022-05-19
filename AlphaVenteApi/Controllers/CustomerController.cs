using AlphaVenteApi.Dtos;
using AlphaVenteApi.Services;
using AlphaVenteData.model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlphaVenteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IServiceGeneric<Customer, CustomerDto> _customerService;

        public CustomerController(IServiceGeneric<Customer,CustomerDto> customerService)
        {
            this._customerService = customerService;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<CustomerDto> Get()
        {
            return _customerService.GetAll();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Task<CustomerDto> Get(int id)
        {
            return _customerService.GetById(id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] CustomerDto customerDto)
        {
            _customerService.Add(customerDto);
        }

        // PUT api/<CustomerController>/5
        [HttpPut]
        public void Put( [FromBody] CustomerDto customerDto,int id)
        {
             
            _customerService.Update(customerDto);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _customerService.Delete(id);
        }
    }
}
