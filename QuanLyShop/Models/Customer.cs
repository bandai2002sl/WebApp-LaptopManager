using Microsoft.AspNetCore.Authorization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyShop.Models
{
    [Authorize]
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Mã ID")] 
        public int Id { get; set; }
        [DisplayName(" Tên ")] 
        public string Name { get; set; }
        public string Email { get; set; }
        [DisplayName("Địa chỉ")] 
        public string Address { get; set; }
        [DisplayName("Số điện thoại")] 
        public string Phone { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }

    }
}
