﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Models.Models
{
    public class ShoppingResponseModel
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
    }
}
