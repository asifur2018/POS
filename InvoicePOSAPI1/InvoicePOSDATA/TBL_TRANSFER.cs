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
    
    public partial class TBL_TRANSFER
    {
        public long BANK_TRANSFER_ID { get; set; }
        public Nullable<long> INVOICE_ID { get; set; }
        public Nullable<decimal> TRANSFER_AMOUNT { get; set; }
        public Nullable<long> TRANSFER_BANK_AC { get; set; }
        public string TRANSFER_BRANCH { get; set; }
        public Nullable<long> TRANSFER_BANK_ID { get; set; }
        public Nullable<System.DateTime> TRANSFER_DATE { get; set; }
        public Nullable<long> USER_ID { get; set; }
    }
}
