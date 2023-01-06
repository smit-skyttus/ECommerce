using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Entity.Manage
{
    public class TransactionReports
    {
        [Key]
        public int ReportId { get; set; }
        [ForeignKey("CustomerId")]
        public Customers customers { get; set; }
        [ForeignKey("OrderId")]
        public ShoppingOrder shoppingOrder { get; set; }
        [ForeignKey("ProductId")]
        public Products products { get; set; }
        [ForeignKey("PaymentId")]
        public Payment payment { get; set; }
    }
}
