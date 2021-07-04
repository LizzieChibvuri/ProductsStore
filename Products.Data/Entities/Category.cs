
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Product.Data
{
    [Table("Category", Schema = "prod")]
    public class Category : Audit
    {
        [Key]
        [Required(ErrorMessage = "Name is required")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "Code is required")]
        public string CategoryCode { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public bool IsActive { get; set; }

    }
}
