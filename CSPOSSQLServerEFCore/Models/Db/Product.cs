using System;
using System.Collections.Generic;

namespace CSPOSSQLServerEFCore.Models.Db
{
    public partial class Product
    {
        public Product()
        {
            SaleDetails = new HashSet<SaleDetail>();
        }

        public int ProductId { get; set; }
        public string ProductBarcode { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public decimal? CostPrice { get; set; }
        public decimal? SellingPrice { get; set; }
        public double? UnitInStock { get; set; }
        public short? ReorderLevel { get; set; }
        public string? CategoryName { get; set; }
        public string? UnitName { get; set; }
        public string? Note { get; set; }

        public virtual ICollection<SaleDetail> SaleDetails { get; set; }
    }
}
