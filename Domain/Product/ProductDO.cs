using Domain.Product.DTO;
using Microsoft.Extensions.Logging;
using InfraStructure.Interface.Product;
using System.Threading.Tasks;

namespace Domain.Product.Impl
{
    public class ProductDO:BaseDO,IProduct
    {

        private IProductInfra infrastructure;
        private ILogger<ProductDO> log = null ;
        public ProductDO(ILogger<ProductDO> logger,IProductInfra infra):base( logger)
        {
            log=logger;
            infrastructure = infra;
        }
        private ProductDTO mProductDTO;
        private int mProductId;
        public async Task<ProductDTO> GetProductDetails()
        {
            mProductDTO = await infrastructure.FetchProductDetails(mProductId);
            //to be changed later to fetch from a non cloneable object.
            return  mProductDTO;
        }

        public bool SetProductCode(int ProductCode)
        {
            mProductId = ProductCode;
            infrastructure.FetchProductDetails(ProductCode);
            return true;
        }
    }
    
}