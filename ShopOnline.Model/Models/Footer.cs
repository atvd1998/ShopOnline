using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnline.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public string ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Content { set; get; }
    }
}