using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/<ProductsController>
        [HttpGet("{lang}")]
        public async Task<IEnumerable<Product>> Get(string? lang)
        {
            return await _productService.GetProducts(lang);
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}/{lang}")]
        public Product Get(int id,string lang)
        {
            return _productService.GetProduct(id,lang);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] ProductDTO pro)
        {
            _productService.Add(pro);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProductDTO pro)
        {
            //
            _productService.Update(id,pro);

        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
