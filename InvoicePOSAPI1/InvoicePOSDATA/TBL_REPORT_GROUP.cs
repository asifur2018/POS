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
    
    public partial class TBL_REPORT_GROUP
    {
        public long REPORT_GRP_ID { get; set; }
        public string GROUP_NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<System.DateTime> DATE { get; set; }
        public Nullable<long> REPORT_ID { get; set; }
        public Nullable<bool> IS_DELETE { get; set; }
        public Nullable<long> COMPANY_ID { get; set; }
        public Nullable<long> CREATED_BY { get; set; }
        public Nullable<long> SGROUP_CODE { get; set; }
        public string REPORT_NAME { get; set; }
        public Nullable<long> USER_ID { get; set; }
    }
}