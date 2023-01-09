using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Entity.Manage
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Categories categories { get; set; }
        public DateTime Date { get; set; }
    }
}
