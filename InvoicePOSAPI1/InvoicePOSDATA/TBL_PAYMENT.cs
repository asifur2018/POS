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
    
    public partial class TBL_PAYMENT
    {
        public long PAYMENT_ID { get; set; }
        public Nullable<int> PAYMENT_TYPE_ID { get; set; }
        public Nullable<long> PAYMENT_INVOICE_ID { get; set; }
        public Nullable<decimal> PAYMENT_AMOUNT { get; set; }
        public Nullable<System.DateTime> PAYMENT_DATE { get; set; }
        public string REFERENCE_NUMBER { get; set; }
        public string PAYMENT_NOTES { get; set; }
        public Nullable<long> COMPANY_ID { get; set; }
        public Nullable<long> USER_ID { get; set; }
    }
}
