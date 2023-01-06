using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Entity.Manage
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [ForeignKey("CategoryId")] 
        public Categories Category { get; set; }
        public string ProductName { get; set; }
    }
}
