﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Models.Models
{
    public class ProductsResponseModel
    {
        public int ProductId { get; set; }
       
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
    }
}
