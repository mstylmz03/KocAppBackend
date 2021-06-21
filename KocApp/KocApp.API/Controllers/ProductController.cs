using KocApp.Business.Abstract;
using KocApp.Business.Concrete;
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
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
       
        public ProductController(IProductService productService)
        {
            _productService = productService;    
        }

        [HttpGet]
        public IActionResult Get()
        {
            var products = _productService.GetAll();
            return Ok(products);    
        }   

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _productService.GetById(id);
            if(product != null)
            {
                return Ok(product);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            if (ModelState.IsValid)
            {
                var createdProduct = _productService.Add(product);
                return CreatedAtAction("Get", new { id = createdProduct.Id }, createdProduct);
            }
            return BadRequest(ModelState);
        }
    }
}
