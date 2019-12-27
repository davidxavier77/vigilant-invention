using System;
using Domain.Product.DTO;
using InfraStructure.Interface.Product;
using Dapper.Contrib.Extensions;
using System.Data;
using Microsoft.Extensions.Logging;
using AutoMapper;
using Product.Database.Models;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace InfraStructure.Implementation.Product
{
    public class ProductinfraImpl: BaseInfraImpl, IProductInfra
    {
        private ILogger<ProductinfraImpl> log;
        private IConfiguration conf;
        
        private IDbConnection conn;
        private IMapper mapper;
        public ProductinfraImpl(IConfiguration configuration,
        ILogger<ProductinfraImpl> logger,IMapper mapperProp):base(configuration,logger)
        {
            log = logger;
            mapper = mapperProp;
            conf = configuration;
        }

        public async Task<ProductDTO> FetchProductDetails(int ProductId)
        {
            ProductDTO retval = null;
            string ConnectionString = conf.GetConnectionString("ProductConnection");
            conn = new SqlConnection(ConnectionString);
            conn.Open();
            var response  = await conn.GetAsync<ProductTable>(ProductId);
            if (response != null)
            {
                retval = new ProductDTO();
                retval.AlternateProductName = response.ProductAlternateName;
                retval.CreatedBy = response.CreatedBy;
                retval.ProductName  = response.ProductName;
            }
            conn.Close();
            return retval;
        }
    }
}