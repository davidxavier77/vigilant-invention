using System.Threading.Tasks;
using Domain.Product.DTO;

namespace Domain.Product.Impl
{
 public interface IProduct
 {
     Task<ProductDTO> GetProductDetails();
     bool SetProductCode(int ProductCode);
     
 }

}