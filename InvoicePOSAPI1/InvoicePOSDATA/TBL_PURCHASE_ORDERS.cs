//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InvoicePOSDATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_PURCHASE_ORDERS
    {
        public long PO_ID { get; set; }
        public string PO_NUMBER { get; set; }
        public Nullable<long> BUSINESS_LOCATION_ID { get; set; }
        public Nullable<System.DateTime> DELIVERY_DATE { get; set; }
        public Nullable<long> SUPPLIER_ID { get; set; }
        public string DELIVERY_TO { get; set; }
        public string BAR_CODE { get; set; }
        public Nullable<long> ITEM_ID { get; set; }
        public string SEARCH_CODE { get; set; }
        public string SEARCH_WITH_STOCK { get; set; }
        public string TERMAS_AND_CONDITIONS { get; set; }
        public Nullable<decimal> TOTAL_TAX { get; set; }
        public Nullable<decimal> TOTAL_AMOUNT { get; set; }
        public Nullable<long> COMPANY_ID { get; set; }
        public Nullable<long> USER_ID { get; set; }
    }
}
