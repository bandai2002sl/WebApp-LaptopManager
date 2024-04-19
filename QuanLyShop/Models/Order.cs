using Microsoft.AspNetCore.Authorization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyShop.Models
{
    [Authorize]
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Mã đơn hàng")] public int Id { get; set; }
        [DisplayName("Mã khách hàng")] public int CustomerId { get; set; }
        [DisplayName("Tên khách hàng")] public virtual Customer? Customer { get; set; }
        [DisplayName("Ngày tạo đơn")] public DateTime CreateAt { get; set; }
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
