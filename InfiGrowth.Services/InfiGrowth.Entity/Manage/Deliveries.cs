using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Entity.Manage
{
    public class Deliveries
    {
        [Key] 
        public int DeliveriesId { get; set; }
        [ForeignKey("CustomerId")]
        public Customers customers { get; set; }
        public DateTime Date { get; set; }
    }
}
