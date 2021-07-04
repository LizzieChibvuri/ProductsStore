using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Product.Data
{
    [Table("Product", Schema = "prod")]
    public class Productt : Audit
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Code is required")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }
        public string CategoryName { get; set; }

        public string Image { get; set; }

        [ForeignKey("CategoryName")]
        public virtual Category Category { get; set; }

    }
}
