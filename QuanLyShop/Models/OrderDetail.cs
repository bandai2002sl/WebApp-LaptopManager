using Microsoft.AspNetCore.Authorization;
using Microsoft.CodeAnalysis;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyShop.Models
{
    [Authorize]
    public class OrderDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int Id { get; set; }
        public int OrderId { get; set; }
        [DisplayName("Id đơn hàng")]
        public virtual Order? Order { get; set; }
        public int ProductId { get; set; }
        [DisplayName("Tên sản phẩm")] public virtual Product? Product { get; set; }
        [DisplayName("Đơn Giá")] public decimal price { get; set; }
        [DisplayName("Số lượng")] public int Quantity { get; set; }
        [DisplayName("Tổng tiền")] public decimal Total { get; set; }
    }
}
