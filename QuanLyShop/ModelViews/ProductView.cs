using QuanLyShop.Models;

namespace QuanLyShop.ModelViews
{
    public class ProductView
    {
        public Product Product { get; set; }
        public Brand? Brand { get; set; }
        public Category? Category { get; set; }

    }
}
