﻿using System.Net.Http.Headers;

namespace eEmana11.Models
{
    public class Detail
    {
        public int DetailID { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public int SubTotal { get; set; }
        public Product Product { get; set; }
        public int ProductID { get; set; }
        public Invoice Invoice { get; set; }
        public int InvoiceID { get; set; }

    }
}
