using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoicePOSAPI.Models
{
    public class CashRegModel
    {
        public long CASH_REGISTERID { get; set; }
        public string BUSINESS_LOCATION { get; set; }
        public long? CASH_REG_NO { get; set; }
        public string CASH_REG_NAME { get; set; }
        public string CASH_REG_PREFIX { get; set; }
        public bool? ISADGUSTMENT { get; set; }
        public string LOGIN { get; set; }
        public bool? IS_MAIN_CASH { get; set; }
        public long? COMPANY_ID { get; set; }
        public decimal? CASH_AMOUNT { get; set; }
        public int TRANSFER_ID { get; set; }
        public int TRANSFER_CODE { get; set; }
        public int FROM_TRAN_CASH_REGISTER { get; set; }
        public int TO_TRAN_CASH_REGISTER { get; set; }
        public bool STATUS { get; set; }

    }
}