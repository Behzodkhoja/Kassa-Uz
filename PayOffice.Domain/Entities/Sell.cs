﻿using PayOffice.Domain.Commons;

namespace PayOffice.Domain.Entities
{
    public class Sell : Auditable
    {
        public int Number { get; set; }
        public long Code { get; set; }
        public long Barcode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime Expiration { get; set; }
    }
}