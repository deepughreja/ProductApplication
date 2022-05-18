using ProductApplication.ViewModel.ViewModels;

namespace ProductApplication.Contract.Contracts
{
    public interface IProductRepository
    {
        public List<ProductData> GetAllProducts();
    }
}
