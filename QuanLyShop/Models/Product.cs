using Microsoft.AspNetCore.Authorization;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyShop.Models
{
    [Authorize]
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Mã ID")] public int Id { get; set; }
        [DisplayName("Tên thiết bị")] public string Name { get; set; }
        [DisplayName("Số lượng")] public int Quantity { get; set; }
        [DisplayName("Đơn giá")] public decimal Price { get; set; }
         public int BrandId { get; set; }
        [DisplayName("Thương hiệu")] public virtual Brand? Brand { get; set; }
        public int CateId { get; set; }
        [DisplayName("Phân loại")] public virtual Category? Category { get; set; }
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
