﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicePOS.Models
{
    public class CashRegModel : IDataErrorInfo
    {
        public long CASH_REGISTERID { get; set; }
       // public long BUSINESS_LOCATION_ID { get; set; }
        public long CASH_REGISTERID_FROM { get; set; }
        public long CASH_REGISTERID_TO { get; set; }
        public long TRANSFER_ID { get; set; }
        public string BUSINESS_LOCATION { get; set; }
        public long BUSINESS_LOCATION_ID { get; set; }
        public long CASH_REG_NO { get; set; }
        public string CASH_REG_NAME { get; set; }
        public string CASH_REG_PREFIX { get; set; }
        public bool ISADGUSTMENT { get; set; }
        public string LOGIN { get; set; }
        public string TRANSFER_CODE { get; set; }
        public bool IS_MAIN_CASH { get; set; }
        public bool IS_TRANSFER_CASH_REGISTER { get; set; }
        public long TO_TRAN_CASH_REGISTER_ID { get; set; }
        public long FROM_TRAN_CASH_REGISTER_ID { get; set; }
        public string TO_TRAN_CASH_REGISTER { get; set; }
        public string FROM_TRAN_CASH_REGISTER { get; set; }
        //public string TO_CASH_REGISTER { get; set; }
        public DateTime TRANSFER_DATE { get; set; }
        public long COMPANY_ID { get; set; }
        public int SLNO { get; set; }
        public decimal CASH_AMOUNT { get; set; }
        public decimal CURRENT_CASH { get; set; }
        public decimal CASH_TO_TRANSFER { get; set; }
        public decimal SUBMITTED_CASH { get; set; }
        public decimal CURRENT_REMAIN { get; set; }
        public string STATUS { get; set; }
        public DateTime FROM_DATE { get; set; }
        public DateTime TO_DATE { get; set; }
        public string CHEQUE_NO { get; set; }
        public decimal CHEQUE_AMOUNT { get; set; }

        private string error = string.Empty;
        public string Error
        {
            get { return error; }
            set { error = value; }
        }
        public string this[string columnName]
        {
            get
            {

                error = string.Empty;

                if (columnName == "BUSINESS_LOCATION" && string.IsNullOrWhiteSpace(BUSINESS_LOCATION))
                {
                    error = "Godown Name is required!";

                }
                if (columnName == "CASH_REG_NAME" && string.IsNullOrWhiteSpace(CASH_REG_NAME))
                {
                    error = "Godown Description is required!";

                }
                if (columnName == "CASH_REG_PREFIX" && string.IsNullOrWhiteSpace(CASH_REG_PREFIX))
                {
                    error = "Godown Description is required!";

                }

                //switch (columnName)
                //{
                //    case "TAX_PAID": if ((TAX_PAID <= 0)) error = "Tax paid is required!"; break;
                //    case "SALES_PRICE": if ((SALES_PRICE <= 0)) error = "Sales Price can not be blank"; break;
                //    case "TAX_COLLECTED": if ((TAX_COLLECTED <= 0)) error = "Tax Collected can not be blank"; break;
                //    case "OPN_QNT": if ((OPN_QNT <= 0)) error = "Opening Qnt can not be blank"; break;
                //    case "MRP": if ((MRP <= 0)) error = "MRP can not be blank"; break;
                //};
                return error;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
