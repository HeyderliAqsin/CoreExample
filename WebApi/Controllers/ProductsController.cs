using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using Entities.Concrete.MyProfiles;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        // GET: api/<ProductsController>
        [HttpGet("{lang}")]
        public async Task<IEnumerable<ProductListDTO>> Get(string? lang)
        {
            var productList=await _productService.GetProducts(lang);
            var _mapperProduct = _mapper.Map<List<Product>,List<ProductListDTO>>(productList);
            return _mapperProduct;
        }

        // GET: api/<ProductsController>
        [HttpGet("{lang}/{searchTerm}")]
        public async Task<JsonResult> Get(string lang, string? searchTerm)
        {
            var result = new JsonResult(new { });
            if (string.IsNullOrWhiteSpace(lang)) return result;
            result.Value = new
            {
                success = true,
                products = await _productService.SearchProducts(searchTerm: searchTerm, langKey: lang)
            };

            return result;
        }

        // GET api/<ProductsController>/5
        [HttpGet("detail/{id}/{lang}")]    
        public ProductDTO Get(int id, string lang)
        {
            var singleProduct = _productService.GetProduct(id, lang);
            var _proMapper = _mapper.Map<ProductDTO>(singleProduct);
            return _proMapper;
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
