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
    
    public partial class TBL_OPENING_BALANCE
    {
        public long OPENING_BALANCE_ID { get; set; }
        public Nullable<long> COMPANY_ID { get; set; }
        public string BUSINESS_LOCATION { get; set; }
        public Nullable<System.DateTime> DATE { get; set; }
        public Nullable<long> BAL_TYPE_ID { get; set; }
        public Nullable<decimal> OPENING_AMT { get; set; }
        public Nullable<decimal> CLOSING_AMT { get; set; }
        public Nullable<System.DateTime> SYSTEM_DATE { get; set; }
        public Nullable<long> CUSTOMER_ID { get; set; }
        public string BAL_TYPE_VALUE { get; set; }
        public Nullable<decimal> CURRENT_OPENING_BALANCE { get; set; }
        public Nullable<decimal> credit_Limits { get; set; }
    }
}
