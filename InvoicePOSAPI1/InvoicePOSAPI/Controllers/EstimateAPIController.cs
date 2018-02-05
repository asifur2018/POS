﻿using InvoicePOSAPI.Models;
using InvoicePOSDATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InvoicePOSAPI.Controllers
{
    public class EstimateAPIController : ApiController
    {
        EstimateModel _EstimateModel = new EstimateModel();
        NEW_POSEntities db = new NEW_POSEntities();
        [HttpGet]
        public HttpResponseMessage GetEstimate()
        {
            //var str1 = (from p in db.TBL_ESTIMATE1
            //            group p by p.ID into grps
            //            select new EstimateModel
            //            {
            //                EstimateId = grps.Key,
            //                //EstimateNo = grps.Select(x => x.ESTIMATE_NO.ToString()),
            //                //EstimateNo = grps.Key,
            //                //Item_Id = Convert.ToInt32(grps.Select( x=> x.ITEM_ID).ToString()),
            //                //ItemName = grps.Select(x => x.ITEM_NAME).ToString(),
            //                //EstimateDate = Convert.ToDateTime(grps.Select(x => x.ESTIMATE_DATE).ToString()),
            //                // Values = grps,
            //                // Datetime=grps.FirstOrDefault(x=>x.ESTIMATE_DATE),
            //                CountItem = grps.Count(),
            //                TotalPrice = grps.Sum(x => x.TOTAL),
            //                TotalTax = grps.Sum(x => x.TOTAL_WITH_TAX),
            //                //TotalTax=0,
            //            }).ToList();
           
            var str1 = (from a in db.TBL_ESTIMATE1
                        join b in db.TBL_ITEMS on a.ITEM_ID equals b.ITEM_ID
                        join c in db.TBL_BUSINESS_LOCATION on b.BUSS_LOC_ID.Value equals c.BUSINESS_LOCATION_ID
                        //join d in db.TBL_INVOICE_PAY on b.ITEM_INVOICE_ID.Value equals d.INVOICE_ID
                        //join e in db.TBL_CASH_REG on d.INVOICE_ID equals e.INVOICE_ID.Value
                        select new ItemModel 
                        {
                            ESTIMATE_DATE = a.ESTIMATE_DATE.Value,
                            ESTIMATE_NO = a.ESTIMATE_NO,
                            BUSINESS_LOCATION = c.SHOP_NAME,
                            //CASH_REG = e.CASH_REG,
                            //INVOICE_DATE = d.INVOICE_DATE.Value,                            
                                IMAGE_PATH = b.IMAGE_PATH,
                                           ITEM_ID = a.ITEM_ID,
                                           ITEM_NAME = a.ITEM_NAME,
                                           ITEM_DESCRIPTION = b.ITEM_DESCRIPTION,
                                           ITEM_PRICE = b.ITEM_PRICE,
                                           ITEM_INVOICE_ID = b.ITEM_INVOICE_ID,
                                           ITEM_PRODUCT_ID = b.ITEM_PRODUCT_ID,
                                           KEYWORD = b.KEYWORD,
                                           ACCESSORIES_KEYWORD = b.ACCESSORIES_KEYWORD,
                                           BARCODE = a.BARCODE,
                                           CATAGORY_ID = b.CATAGORY_ID,
                                           CATEGORY_NAME = b.CATEGORY_NAME,
                                           SEARCH_CODE = b.SERCH_CODE,
                                           TAX_PAID = b.TAX_PAID,
                                           TAX_COLLECTED = b.TAX_COLLECTED,
                                           //CUSTOMER_NAME = a.c
                                           BUSINESS_LOC = b.ITEM_LOCATION,
                                           BUSS_LOC_ID = b.BUSS_LOC_ID,
                                           GODOWN_ID = b.GODOWN_ID,
                                           UNIT_SALES_ID = b.SALE_UNIT_ID,
                                           UNIT_PURCHAGE_ID = b.PURCHAGE_UNIT_ID,
                                           PURCHASE_UNIT = b.PURCHASE_UNIT,
                                           SALES_UNIT = b.SALES_UNIT,
                                           PURCHASE_UNIT_PRICE = b.PURCHASE_UNIT_PRICE,
                                           SALES_PRICE = b.SALES_PRICE,
                                           MRP = b.MRP,
                                           COMPANY_ID = b.COMPANY_ID,

                                           OPN_QNT = b.OPN_QNT,
                                           DISPLAY_INDEX = b.DISPLAY_INDEX,
                                           ITEM_GROUP_NAME = b.ITEM_GROUP_NAME,
                                           ITEM_UNIQUE_NAME = b.ITEM_UNIQUE_NAME,
                                           REGIONAL_LANGUAGE = b.REGIONAL_LANGUAGE,
                                           SALES_PRICE_BEFOR_TAX = b.SALES_PRICE_BEFOR_TAX,
                                           IS_DELETE = a.IS_DELETE,
                                           INCLUDE_TAX = b.INCLUDE_TAX,
                                           IS_Shortable_Item = false,
                                           IS_Purchased = false,
                                           IS_Service_Item = false,
                                           IS_For_Online_Shop = false,
                                           IS_Not_for_online_shop = false,
                                           IS_Not_For_Sell = false,
                                           ALLOW_PURCHASE_ON_ESHOP = false,
                                           IS_ACTIVE = b.IS_ACIVE,
                                           IS_Gift_Card = false,
                                           MODIFICATION_DATE = b.MODIFICATION_DATE,
                                           WEIGHT_OF_CARDBOARD = b.WEIGHT_OF_CARDBOARD,
                                           WEIGHT_OF_FOAM = b.WEIGHT_OF_FOAM,
                                           WEIGHT_OF_PLASTIC = b.WEIGHT_OF_PLASTIC,
                                           WEIGHT_OF_PAPER = b.WEIGHT_OF_PAPER,
                                           //GODOWN = b.GODOWN,
                                           DATE = System.DateTime.Now,
                                           //COMPANY_NAME = b.COMPANY_NAME,
                                           TAX_COLLECTED_NAME = b.TAX_COLLECTED_NAME,
                                           //TAX_PAID_NAME = a.TAX_PAID_NAME,
                                           TaxName = a.TAX_NAME,
                                           //TaxValue = a.TAX_VALUE,
                                           Current_Qty = b.OPN_QNT,
                                           Total = b.SALES_PRICE,
                                       }); 
                       
            return Request.CreateResponse(HttpStatusCode.OK, str1);
        }
        [HttpGet]
        public HttpResponseMessage GetEstimateItem(int id)
        {
            List<ItemModel> _ItemModel = new List<ItemModel>();
            if (id != null && id != 0)
            {
                var ItemCount = (from a in db.TBL_ESTIMATE1 join b in db.TBL_ITEMS on a.ITEM_ID equals b.ITEM_ID where a.ID == id select a.ITEM_ID).ToList();
                if (ItemCount.Count > 0)
                {

                    foreach (var item in ItemCount)
                    {
                        var m = db.View_ITEM_ATTRIBUTE.ToList();

                        var str = (from a in db.View_ITEM_ATTRIBUTE.ToList() join c in db.TBL_ITEMS on a.ITEM_ID equals c.ITEM_ID 
                                   where a.ITEM_ID == item && a.IS_DELETE == false
                                   select new ItemModel
                                   {
                                           IMAGE_PATH = a.IMAGE_PATH,
                                           ITEM_ID = a.ITEM_ID,
                                           ITEM_NAME = a.ITEM_NAME,
                                           ITEM_DESCRIPTION = a.ITEM_DESCRIPTION,
                                           ITEM_PRICE = a.ITEM_PRICE,
                                           ITEM_INVOICE_ID = a.ITEM_INVOICE_ID,
                                           ITEM_PRODUCT_ID = a.ITEM_PRODUCT_ID,
                                           KEYWORD = a.KEYWORD,
                                           ACCESSORIES_KEYWORD = a.ACCESSORIES_KEYWORD,
                                           BARCODE = a.BARCODE,
                                           CATAGORY_ID = a.CATAGORY_ID,
                                           CATEGORY_NAME = a.CATEGORY_NAME,
                                           SEARCH_CODE = a.SERCH_CODE,
                                           TAX_PAID = a.TAX_PAID,
                                           TAX_COLLECTED = a.TAX_COLLECTED,

                                           BUSINESS_LOC = a.BUSSINESS_LOCATION,
                                           BUSS_LOC_ID = a.BUSS_LOC_ID,
                                           GODOWN_ID = a.GODOWN_ID,
                                           UNIT_SALES_ID = a.SALE_UNIT_ID,
                                           UNIT_PURCHAGE_ID = a.PURCHAGE_UNIT_ID,
                                           PURCHASE_UNIT = a.PURCHASE_UNIT,
                                           SALES_UNIT = a.SALES_UNIT,
                                           PURCHASE_UNIT_PRICE = a.PURCHASE_UNIT_PRICE,
                                           SALES_PRICE = a.SALES_PRICE,
                                           MRP = a.MRP,
                                           COMPANY_ID = a.COMPANY_ID,

                                           OPN_QNT = a.OPN_QNT,
                                           DISPLAY_INDEX = a.DISPLAY_INDEX,
                                           ITEM_GROUP_NAME = a.ITEM_GROUP_NAME,
                                           ITEM_UNIQUE_NAME = a.ITEM_UNIQUE_NAME,
                                           REGIONAL_LANGUAGE = a.REGIONAL_LANGUAGE,
                                           SALES_PRICE_BEFOR_TAX = a.SALES_PRICE_BEFOR_TAX,
                                           IS_DELETE = a.IS_DELETE,
                                           INCLUDE_TAX = a.INCLUDE_TAX,
                                           IS_Shortable_Item = false,
                                           IS_Purchased = false,
                                           IS_Service_Item = false,
                                           IS_For_Online_Shop = false,
                                           IS_Not_for_online_shop = false,
                                           IS_Not_For_Sell = false,
                                           ALLOW_PURCHASE_ON_ESHOP = false,
                                           IS_ACTIVE = a.IS_ACIVE,
                                           IS_Gift_Card = false,
                                           MODIFICATION_DATE = a.MODIFICATION_DATE,
                                           WEIGHT_OF_CARDBOARD = a.WEIGHT_OF_CARDBOARD,
                                           WEIGHT_OF_FOAM = a.WEIGHT_OF_FOAM,
                                           WEIGHT_OF_PLASTIC = a.WEIGHT_OF_PLASTIC,
                                           WEIGHT_OF_PAPER = a.WEIGHT_OF_PAPER,
                                           GODOWN = a.GODOWN,
                                           DATE = a.DATE,
                                           COMPANY_NAME = a.COMPANY_NAME,
                                           TAX_COLLECTED_NAME = a.TAX_COLLECTED_NAME,
                                           TAX_PAID_NAME = a.TAX_PAID_NAME,
                                           TaxName = a.TAX_NAME,
                                           TaxValue = a.TAX_VALUE,
                                           Current_Qty = (from b in db.TBL_ESTIMATE1 where b.ITEM_ID == item && b.ID == id select b.CURRENT_QTY).FirstOrDefault(),
                                           Total = (from b in db.TBL_ESTIMATE1 where b.ITEM_ID == item && b.ID == id select b.TOTAL).FirstOrDefault(),
                                       }).FirstOrDefault(); 
                                   
                                   
                        if (str != null)
                        {
                            _ItemModel.Add(new ItemModel
                            {
                                IMAGE_PATH = str.IMAGE_PATH,
                                ITEM_ID = str.ITEM_ID,
                                ITEM_NAME = str.ITEM_NAME,
                                ITEM_DESCRIPTION = str.ITEM_DESCRIPTION,
                                ITEM_PRICE = str.ITEM_PRICE,
                                ITEM_INVOICE_ID = str.ITEM_INVOICE_ID,
                                ITEM_PRODUCT_ID = str.ITEM_PRODUCT_ID,
                                KEYWORD = str.KEYWORD,
                                ACCESSORIES_KEYWORD = str.ACCESSORIES_KEYWORD,
                                BARCODE = str.BARCODE,
                                CATAGORY_ID = str.CATAGORY_ID,
                                CATEGORY_NAME = str.CATEGORY_NAME,
                                SEARCH_CODE = str.SEARCH_CODE,
                                TAX_PAID = str.TAX_PAID,
                                TAX_COLLECTED = str.TAX_COLLECTED,

                                BUSINESS_LOC = str.BUSINESS_LOC,
                                BUSS_LOC_ID = str.BUSS_LOC_ID,
                                GODOWN_ID = str.GODOWN_ID,
                                UNIT_SALES_ID = str.UNIT_SALES_ID,
                                UNIT_PURCHAGE_ID = str.UNIT_PURCHAGE_ID,
                                PURCHASE_UNIT = str.PURCHASE_UNIT,
                                SALES_UNIT = str.SALES_UNIT,
                                PURCHASE_UNIT_PRICE = str.PURCHASE_UNIT_PRICE,
                                SALES_PRICE = str.SALES_PRICE,
                                MRP = str.MRP,
                                COMPANY_ID = str.COMPANY_ID,

                                OPN_QNT = str.OPN_QNT,
                                DISPLAY_INDEX = str.DISPLAY_INDEX,
                                ITEM_GROUP_NAME = str.ITEM_GROUP_NAME,
                                ITEM_UNIQUE_NAME = str.ITEM_UNIQUE_NAME,
                                REGIONAL_LANGUAGE = str.REGIONAL_LANGUAGE,
                                SALES_PRICE_BEFOR_TAX = str.SALES_PRICE_BEFOR_TAX,
                                IS_DELETE = str.IS_DELETE,
                                INCLUDE_TAX = str.INCLUDE_TAX,
                                IS_Shortable_Item = false,
                                IS_Purchased = false,
                                IS_Service_Item = false,
                                IS_For_Online_Shop = false,
                                IS_Not_for_online_shop = false,
                                IS_Not_For_Sell = false,
                                ALLOW_PURCHASE_ON_ESHOP = false,
                                IS_ACTIVE = str.IS_ACTIVE,
                                IS_Gift_Card = false,
                                MODIFICATION_DATE = str.MODIFICATION_DATE,
                                WEIGHT_OF_CARDBOARD = str.WEIGHT_OF_CARDBOARD,
                                WEIGHT_OF_FOAM = str.WEIGHT_OF_FOAM,
                                WEIGHT_OF_PLASTIC = str.WEIGHT_OF_PLASTIC,
                                WEIGHT_OF_PAPER = str.WEIGHT_OF_PAPER,
                                GODOWN = str.GODOWN,
                                DATE = str.DATE,
                                COMPANY_NAME = str.COMPANY_NAME,
                                TAX_COLLECTED_NAME = str.TAX_COLLECTED_NAME,
                                TAX_PAID_NAME = str.TAX_PAID_NAME,
                                TaxName = str.TaxName,
                                TaxValue = str.TaxValue,
                                Current_Qty = str.Current_Qty,
                                Total = str.Total,
                            });
                        }
                        

                    }
                }
            }
            return Request.CreateResponse(HttpStatusCode.OK, _ItemModel);
        }
        [HttpGet]
        public HttpResponseMessage DeleteEstimate(int id)
        {
            var str = (from a in db.TBL_ESTIMATE1 where a.ID == id select a).FirstOrDefault();
            str.IS_DELETE = true;
            db.TBL_ESTIMATE1.Remove(str);
            db.SaveChanges(); 
            return Request.CreateResponse(HttpStatusCode.OK, "success");


        }

        [HttpGet]
        public HttpResponseMessage ViewEstimateItem(int id)
        {
            List<ItemModel> _ItemEstimate = new List<ItemModel>();
            List<EstimateModel> _EstimateModel = new List<EstimateModel>();
            if (id != null && id != 0)
            {
                var ItemCount = (from a in db.TBL_ESTIMATE1 where a.ID == id select a.ITEM_ID).ToList();
                if (ItemCount.Count > 0)
                {

                    foreach (var item in ItemCount)
                    {
                        var m = db.View_ITEM_ATTRIBUTE.ToList();
                        var TotalWithTax = (from b in db.TBL_ESTIMATE1 where b.ITEM_ID == item && b.ID == id select b.TOTAL_WITH_TAX).FirstOrDefault();
                        var Total = (from b in db.TBL_ESTIMATE1 where b.ITEM_ID == item && b.ID == id select b.TOTAL).FirstOrDefault();
                        var str = (from a in db.View_ITEM_ATTRIBUTE.ToList()
                                   where a.ITEM_ID == item && a.IS_DELETE == false
                                   select new ItemModel
                                   {
                                       IMAGE_PATH = a.IMAGE_PATH,
                                       ITEM_ID = a.ITEM_ID,
                                       ITEM_NAME = a.ITEM_NAME,
                                       ITEM_DESCRIPTION = a.ITEM_DESCRIPTION,
                                       ITEM_PRICE = a.ITEM_PRICE,
                                       ITEM_INVOICE_ID = a.ITEM_INVOICE_ID,
                                       ITEM_PRODUCT_ID = a.ITEM_PRODUCT_ID,
                                       KEYWORD = a.KEYWORD,
                                       ACCESSORIES_KEYWORD = a.ACCESSORIES_KEYWORD,
                                       BARCODE = a.BARCODE,
                                       CATAGORY_ID = a.CATAGORY_ID,
                                       CATEGORY_NAME = a.CATEGORY_NAME,
                                       SEARCH_CODE = a.SERCH_CODE,
                                       TAX_PAID = a.TAX_PAID,
                                       TAX_COLLECTED = a.TAX_COLLECTED,

                                       BUSINESS_LOC = a.BUSSINESS_LOCATION,
                                       BUSS_LOC_ID = a.BUSS_LOC_ID,
                                       GODOWN_ID = a.GODOWN_ID,
                                       UNIT_SALES_ID = a.SALE_UNIT_ID,
                                       UNIT_PURCHAGE_ID = a.PURCHAGE_UNIT_ID,
                                       PURCHASE_UNIT = a.PURCHASE_UNIT,
                                       SALES_UNIT = a.SALES_UNIT,
                                       PURCHASE_UNIT_PRICE = a.PURCHASE_UNIT_PRICE,
                                       SALES_PRICE = a.SALES_PRICE,
                                       MRP = a.MRP,
                                       COMPANY_ID = a.COMPANY_ID,

                                       OPN_QNT = a.OPN_QNT,
                                       DISPLAY_INDEX = a.DISPLAY_INDEX,
                                       ITEM_GROUP_NAME = a.ITEM_GROUP_NAME,
                                       ITEM_UNIQUE_NAME = a.ITEM_UNIQUE_NAME,
                                       REGIONAL_LANGUAGE = a.REGIONAL_LANGUAGE,
                                       SALES_PRICE_BEFOR_TAX = a.SALES_PRICE_BEFOR_TAX,
                                       IS_DELETE = a.IS_DELETE,
                                       INCLUDE_TAX = a.INCLUDE_TAX,
                                       IS_Shortable_Item = false,
                                       IS_Purchased = false,
                                       IS_Service_Item = false,
                                       IS_For_Online_Shop = false,
                                       IS_Not_for_online_shop = false,
                                       IS_Not_For_Sell = false,
                                       ALLOW_PURCHASE_ON_ESHOP = false,
                                       IS_ACTIVE = a.IS_ACIVE,
                                       IS_Gift_Card = false,
                                       MODIFICATION_DATE = a.MODIFICATION_DATE,
                                       WEIGHT_OF_CARDBOARD = a.WEIGHT_OF_CARDBOARD,
                                       WEIGHT_OF_FOAM = a.WEIGHT_OF_FOAM,
                                       WEIGHT_OF_PLASTIC = a.WEIGHT_OF_PLASTIC,
                                       WEIGHT_OF_PAPER = a.WEIGHT_OF_PAPER,
                                       GODOWN = a.GODOWN,
                                       DATE = a.DATE,
                                       COMPANY_NAME = a.COMPANY_NAME,
                                       TAX_COLLECTED_NAME = a.TAX_COLLECTED_NAME,
                                       TAX_PAID_NAME = a.TAX_PAID_NAME,
                                       TaxName = a.TAX_NAME,
                                       TaxValue = a.TAX_VALUE,
                                       Current_Qty = (from b in db.TBL_ESTIMATE1 where b.ITEM_ID == item && b.ID == id select b.CURRENT_QTY).FirstOrDefault(),
                                       Total = (from b in db.TBL_ESTIMATE1 where b.ITEM_ID == item && b.ID == id select b.TOTAL).FirstOrDefault(),
                                       TotalTax = (TotalWithTax - Total)
                                   }).FirstOrDefault();
                        if (str != null)
                        {
                            _EstimateModel.Add(new EstimateModel
                            {
                                Barcode = str.BARCODE,
                                BusinessLoc = str.BUSINESS_LOC,
                                CurrentQty = str.Current_Qty.Value,
                                EstimateDate = str.DATE.Value,
                                EstimateNo = (from b in db.TBL_ESTIMATE1 where b.ITEM_ID == item && b.ID == id select b.ESTIMATE_NO).FirstOrDefault(),
                                EstimateId = (from b in db.TBL_ESTIMATE1 where b.ITEM_ID == item && b.ID == id select b.ID).FirstOrDefault(),
                                ItemName =str.ITEM_NAME,
                                Item_Id = str.ITEM_ID.Value,
                                TotalPrice = str.Total,
                                TotalTax = str.TotalTax
                                //IMAGE_PATH = str.IMAGE_PATH,
                                //ITEM_ID = str.ITEM_ID,
                                //ITEM_NAME = str.ITEM_NAME,
                                //ITEM_DESCRIPTION = str.ITEM_DESCRIPTION,
                                //ITEM_PRICE = str.ITEM_PRICE,
                                //ITEM_INVOICE_ID = str.ITEM_INVOICE_ID,
                                //ITEM_PRODUCT_ID = str.ITEM_PRODUCT_ID,
                                //KEYWORD = str.KEYWORD,
                                //ACCESSORIES_KEYWORD = str.ACCESSORIES_KEYWORD,
                                //BARCODE = str.BARCODE,
                                //CATAGORY_ID = str.CATAGORY_ID,
                                //CATEGORY_NAME = str.CATEGORY_NAME,
                                //SEARCH_CODE = str.SEARCH_CODE,
                                //TAX_PAID = str.TAX_PAID,
                                //TAX_COLLECTED = str.TAX_COLLECTED,

                                //BUSINESS_LOC = str.BUSINESS_LOC,
                                //BUSS_LOC_ID = str.BUSS_LOC_ID,
                                //GODOWN_ID = str.GODOWN_ID,
                                //UNIT_SALES_ID = str.UNIT_SALES_ID,
                                //UNIT_PURCHAGE_ID = str.UNIT_PURCHAGE_ID,
                                //PURCHASE_UNIT = str.PURCHASE_UNIT,
                                //SALES_UNIT = str.SALES_UNIT,
                                //PURCHASE_UNIT_PRICE = str.PURCHASE_UNIT_PRICE,
                                //SALES_PRICE = str.SALES_PRICE,
                                //MRP = str.MRP,
                                //COMPANY_ID = str.COMPANY_ID,

                                //OPN_QNT = str.OPN_QNT,
                                //DISPLAY_INDEX = str.DISPLAY_INDEX,
                                //ITEM_GROUP_NAME = str.ITEM_GROUP_NAME,
                                //ITEM_UNIQUE_NAME = str.ITEM_UNIQUE_NAME,
                                //REGIONAL_LANGUAGE = str.REGIONAL_LANGUAGE,
                                //SALES_PRICE_BEFOR_TAX = str.SALES_PRICE_BEFOR_TAX,
                                //IS_DELETE = str.IS_DELETE,
                                //INCLUDE_TAX = str.INCLUDE_TAX,
                                //IS_Shortable_Item = false,
                                //IS_Purchased = false,
                                //IS_Service_Item = false,
                                //IS_For_Online_Shop = false,
                                //IS_Not_for_online_shop = false,
                                //IS_Not_For_Sell = false,
                                //ALLOW_PURCHASE_ON_ESHOP = false,
                                //IS_ACTIVE = str.IS_ACTIVE,
                                //IS_Gift_Card = false,
                                //MODIFICATION_DATE = str.MODIFICATION_DATE,
                                //WEIGHT_OF_CARDBOARD = str.WEIGHT_OF_CARDBOARD,
                                //WEIGHT_OF_FOAM = str.WEIGHT_OF_FOAM,
                                //WEIGHT_OF_PLASTIC = str.WEIGHT_OF_PLASTIC,
                                //WEIGHT_OF_PAPER = str.WEIGHT_OF_PAPER,
                                //GODOWN = str.GODOWN,
                                //DATE = str.DATE,
                                //COMPANY_NAME = str.COMPANY_NAME,
                                //TAX_COLLECTED_NAME = str.TAX_COLLECTED_NAME,
                                //TAX_PAID_NAME = str.TAX_PAID_NAME,
                                //TaxName = str.TaxName,
                                //TaxValue = str.TaxValue,
                                //Current_Qty = str.Current_Qty,
                                //Total = str.Total,
                                //TotalTax = str.TotalTax
                            });
                        }


                    }
                }
            }
            return Request.CreateResponse(HttpStatusCode.OK, _EstimateModel);
        }
    }
}
