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
    
    public partial class TBL_DEPARTMENT
    {
        public long DEPARTMENT_ID { get; set; }
        public string DEPARTMENT_NAME { get; set; }
        public long COMPANY_ID { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public Nullable<long> CREATED_BY { get; set; }
        public Nullable<bool> STATUS { get; set; }
        public Nullable<bool> IS_DELETE { get; set; }
        public Nullable<long> SORT_INDEX { get; set; }
    }
}