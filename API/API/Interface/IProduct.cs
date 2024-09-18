using Model.Entities;

namespace API.Interface
{
    public interface IProduct
    {
        IList<Product> AddProduct();
    }
}
