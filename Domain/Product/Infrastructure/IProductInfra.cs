/*
    Interface to fetch data from data store.
    THe interface is specific to the Product

*/
using System.Threading.Tasks;
using Domain.Product.DTO;

namespace InfraStructure.Interface.Product
{
    public interface IProductInfra
    {
        public Task<ProductDTO> FetchProductDetails(int ProductId);
    }    
}

