using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoicePOSAPI.Models
{
    public class HoldInvoice
    {
        public int Invoice_ID { get; set; }
        public string Invoice_No { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Barcode { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalTax { get; set; }
        public decimal SALES_PRICE_BEFOR_TAX_QTY { get; set; }
        public int Current_Qty { get; set; }
        public decimal Discount { get; set; }
        public decimal SalePriceWithDiscount { get; set; }
        public decimal TaxValue { get; set; }
        
    }
}