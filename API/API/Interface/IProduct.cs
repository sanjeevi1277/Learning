using Model.Entities;

namespace API.Interface
{
    public interface IProduct
    {
        string AddProduct(Product product);
        IEnumerable<Product> GetProduct();
    }
}
