﻿using Microsoft.AspNetCore.Mvc;

namespace GatewayExample.Product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository customerRepository)
        {
            _productRepository = customerRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllCustomers()
        {
            return await _productRepository.GetAllProducts();
        }
    }
}