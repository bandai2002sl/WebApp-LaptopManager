using Microsoft.AspNetCore.Authorization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyShop.Models
{
    [Table("Brands")]
    [Authorize]
    public class Brand
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [DisplayName("Mã ID")] 
        public int Id { get; set; }
        [DisplayName("Tên")]
        public string Name { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}
