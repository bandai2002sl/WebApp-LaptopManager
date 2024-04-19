using Microsoft.AspNetCore.Authorization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyShop.Models
{
    [Table("Categories")]
    [Authorize]
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Mã ID")] 
        public int Id { get; set; }
        [DisplayName("Loại")] 
        public string Name { get; set; }
        public virtual ICollection<Product>? Products { get; set; }

    }
}
