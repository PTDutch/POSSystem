using System;
using System.Collections.Generic;

namespace CSPOSSQLServerEFCore.Models.Db
{
    public partial class SaleDetail
    {
        public int AutoId { get; set; }
        public string? SaleId { get; set; }
        public int? ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal? ProductPrice { get; set; }
        public double? ProductQuantity { get; set; }
        public decimal? Subtotal { get; set; }

        public virtual Product? Product { get; set; }
        public virtual Sale? Sale { get; set; }
    }
}
