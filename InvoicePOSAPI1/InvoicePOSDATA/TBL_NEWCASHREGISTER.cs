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
    
    public partial class TBL_NEWCASHREGISTER
    {
        public long CASH_REGISTERID { get; set; }
        public string BUSINESS_LOCATION { get; set; }
        public Nullable<long> CASH_REG_NO { get; set; }
        public string CASH_REG_NAME { get; set; }
        public string CASH_REG_PREFIX { get; set; }
        public Nullable<bool> IS_ADGUSTMENT { get; set; }
        public string LOGIN { get; set; }
        public Nullable<bool> IS_MAIN_CASH { get; set; }
        public Nullable<long> COMPANY_ID { get; set; }
        public Nullable<bool> IS_DELETE { get; set; }
        public Nullable<long> USER_ID { get; set; }
        public Nullable<decimal> CASH_AMOUNT { get; set; }
    }
}
