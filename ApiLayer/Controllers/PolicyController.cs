using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLayer.Models;
using AutoMapper;
using Domain.Product.Impl;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiLayer.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly ILogger<ProductController> _logger;
        private readonly IProduct product;
        private IMapper mapper;

        public ProductController(ILogger<ProductController> logger,IProduct Product,IMapper Mapper)
        {
            _logger = logger;
            product = Product;
            mapper = Mapper;
        }

        [HttpGet("{ProductCode}")]
        public async Task<ProductModel> Get(int ProductCode)
        {
            product.SetProductCode(ProductCode);
            var returnVal = await product.GetProductDetails();
            var retVal = mapper.Map<ProductModel>(returnVal);
            return retVal;
        }
    }
}