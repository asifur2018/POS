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
    
    public partial class TBL_BUSINESS_LOCATION
    {
        public long BUSINESS_LOCATION_ID { get; set; }
        public Nullable<long> COMPANY_ID { get; set; }
        public string SHOP_NAME { get; set; }
        public string PREFIX_DOCUMENT { get; set; }
        public string DOCUMENT_NO { get; set; }
        public string TIN_NUMBER { get; set; }
        public string BUSS_ADDRESS_1 { get; set; }
        public string BUSS_ADDRESS_2 { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string COUNTRY { get; set; }
        public string PIN { get; set; }
        public string PHONE_NO { get; set; }
        public string MOBILE_NO { get; set; }
        public string EMAIL { get; set; }
        public string WEBSITE { get; set; }
        public string COMPANY { get; set; }
        public string PRINTER_SETTING { get; set; }
        public string SMS_SETTING { get; set; }
        public string EMAIL_SETTING { get; set; }
        public string EMAIL_TEMPLATE_SETTING { get; set; }
        public string SCEOND_RECEIPT_PRINTER { get; set; }
        public string SCEOND_RECEIPT_PRINT_FORMATE { get; set; }
        public string NUMBER_OF_SECOND_RECEIPT_PRINT { get; set; }
        public string GODOWN_TO_KEEP { get; set; }
        public Nullable<bool> IS_ENABLE_EMAIL { get; set; }
        public Nullable<bool> IS_SCEOND_RECEIPT_PRINTER { get; set; }
        public Nullable<bool> IS_SECOND_DIFF_PRINT { get; set; }
        public Nullable<bool> IS_ASK_TO_PRIENT_EVERYTIME { get; set; }
        public Nullable<bool> IS_DELETE_INVOICE_SPECIFIED_GODOWN { get; set; }
        public Nullable<bool> IS_DELETE { get; set; }
        public string IMAGE { get; set; }
        public Nullable<long> USER_ID { get; set; }
    }
}
