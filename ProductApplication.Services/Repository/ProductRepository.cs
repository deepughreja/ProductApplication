using AutoMapper;
using ProductApplication.Contract.Contracts;
using ProductApplication.DatabaseEntities;
using ProductApplication.ViewModel.ViewModels;

namespace ProductApplication.Repository.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;
        private readonly IMapper _mapper;

        public ProductRepository(ProductContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public List<ProductData> GetAllProducts()
        {
            var products = _context.Products.ToList();
            var productsData = _mapper.Map<List<ProductData>>(products);
            return productsData;
        }
    }
}
