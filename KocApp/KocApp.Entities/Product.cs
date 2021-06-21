using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KocApp.Entities
{
    public class Product
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string ProductName { get; set; }
        [StringLength(50)]
        public string ProductDescription { get; set; }
        [Required]
        public Decimal UnitPrice { get; set; }
        [Required]
        public Decimal UnitStock { get; set; }

    }
}
