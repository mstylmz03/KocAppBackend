using KocApp.Business.Abstract;
using KocApp.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KocApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var customers = _customerService.GetAll();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var customer = _customerService.GetById(id);
            if (customer != null)
            {
                return Ok(customer);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult Post([FromBody] Customer customer)
        {
            if (ModelState.IsValid)
            {
                var createdProduct = _customerService.Add(customer);
                return CreatedAtAction("Get", new { id = createdProduct.Id }, createdProduct);
            }
            return BadRequest(ModelState);
        }

    }
}
