using API.Interface;
using Model.DB;
using Model.Entities;

namespace API.Services
{
    public class ProductService : IProduct
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext db)
        {
            _context = db;
        }

        public string AddProduct(Product product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return "Product Added Successfully";

            }
            catch (Exception ex)
            {
                return "Failed to add Product" + ex.Message;

            }
        }
        public IEnumerable<Product> GetProduct()
        {
          return  _context.Products.ToList();
        }

    }
}
