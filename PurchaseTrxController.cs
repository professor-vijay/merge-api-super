using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using SuperMarketApi.Models;

namespace SuperMarketApi.Controllers
{
    public class PurchaseTrxController : Controller
    {
        private POSDbContext db;
        public IConfiguration Configuration { get; }
        [HttpGet("GetPurchaseTrx")]
        public IActionResult GetPurchaseTrx(JObject objData)
        {
            try
            {
                dynamic jsonObj = objData;
                int? searchContactId = jsonObj.searchContactId;
                int? billStatus = jsonObj.billStatus;
                DateTime? dateFrom = jsonObj.dateFrom;
                DateTime? dateTo = jsonObj.dateTo;
                int companyId = jsonObj.companyId;
                int? storeID = jsonObj.storeID;
                int? billId = jsonObj.billId;
                int? numRecords = jsonObj.numRecords;
                int? amountFrom = jsonObj.amountFrom;
                int? amountUpto = jsonObj.amountUpto;
                int? receiverStoreId = jsonObj.receiverStoreId;
                string UserID = jsonObj.UserID;

                SqlConnection sqlCon = new SqlConnection(Configuration.GetConnectionString("myconn"));
                sqlCon.Open();

                SqlCommand cmd = new SqlCommand("dbo.PurchaseIndex", sqlCon);

                cmd.Parameters.Add(new SqlParameter("@searchContactId", searchContactId));
                cmd.Parameters.Add(new SqlParameter("@billStatus", billStatus));
                cmd.Parameters.Add(new SqlParameter("@fromDate", dateFrom));
                cmd.Parameters.Add(new SqlParameter("@toDate", dateTo));
                cmd.Parameters.Add(new SqlParameter("@storeID", storeID));
                cmd.Parameters.Add(new SqlParameter("@billId", billId));
                cmd.Parameters.Add(new SqlParameter("@numRecords", numRecords + 1));
                cmd.Parameters.Add(new SqlParameter("@userId", UserID));
                cmd.Parameters.Add(new SqlParameter("@amountFrom", amountFrom));
                cmd.Parameters.Add(new SqlParameter("@amountUpto", amountUpto));
                cmd.Parameters.Add(new SqlParameter("@receiverStoreId", receiverStoreId));
                cmd.Parameters.Add(new SqlParameter("@companyId", companyId));
                SqlDataAdapter sqlAdp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                sqlAdp.Fill(ds);
                DataTable table = ds.Tables[0];
                var response = new
                {
                    status = 200,
                    purchaseTrx = table
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    status = 0,
                    msg = "Something Went Wrong",
                    error = new Exception(ex.Message, ex.InnerException)
                };
                return Ok(response);
            }
        }
        [HttpGet("GetBillPay")]
        public IActionResult GetBillPay(JObject objData)
        {
            try
            {
                dynamic jsonObj = objData;
                int? searchContactId = jsonObj.searchContactId;
                DateTime? dateFrom = jsonObj.dateFrom;
                DateTime? dateTo = jsonObj.dateTo;
                int companyId = jsonObj.companyId;
                int? storeID = jsonObj.storeID;
                int? numRecords = jsonObj.numRecords;
                int? transactionId = jsonObj.transactionId;
                int? amountFrom = jsonObj.amountFrom;
                int? amountUpto = jsonObj.amountUpto;
                string UserID = jsonObj.UserID;

                SqlConnection sqlCon = new SqlConnection(Configuration.GetConnectionString("myconn"));
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("dbo.BillPayIndex", sqlCon);
                cmd.Parameters.Add(new SqlParameter("@transactionId", transactionId));
                cmd.Parameters.Add(new SqlParameter("@searchContactId", searchContactId));
                cmd.Parameters.Add(new SqlParameter("@fromDate", dateFrom));
                cmd.Parameters.Add(new SqlParameter("@toDate", dateTo));
                cmd.Parameters.Add(new SqlParameter("@storeID", storeID));
                cmd.Parameters.Add(new SqlParameter("@userId", UserID));
                cmd.Parameters.Add(new SqlParameter("@numRecords", numRecords + 1));
                cmd.Parameters.Add(new SqlParameter("@amountFrom", amountFrom));
                cmd.Parameters.Add(new SqlParameter("@amountUpto", amountUpto));
                cmd.Parameters.Add(new SqlParameter("@companyId", companyId));

                SqlDataAdapter sqlAdp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                sqlAdp.Fill(ds);
                DataTable table = ds.Tables[0];
                var response = new
                {
                    status = 200,
                    billPay = table
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    status = 0,
                    msg = "Something Went Wrong",
                    error = new Exception(ex.Message, ex.InnerException)
                };
                return Ok(response);
            }
        }
        [HttpPost("Update")]
        public ActionResult Update(JObject objData)
        {
            try
            {
                dynamic jsonObj = objData;
                int companyId = jsonObj.companyId;
                int userId = jsonObj.userId;
                Transaction trans = jsonObj.ToObject<Transaction>();
                trans = jsonObj.ToObject<Transaction>();
                JArray items = jsonObj.items;
                dynamic creditArr = items.ToList();

                TransControllerExt.UpdateTrans(db, trans, false,companyId);
                TransControllerExt.BillnPaysEdit(db, creditArr);
                db.SaveChanges();
                var response = new
                {
                    status = 200,
                    transactionId = trans.Id,
                    msg="Data Updated Successfully"
                };
                return Json(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    status = 0,
                    msg = "Something Went Wrong",
                    error = new Exception(ex.Message, ex.InnerException)
                };
                return Ok(response);
            }
        }
        [HttpPost("DeleteBillPay")]

        public ActionResult DeleteBillPay(int id, int companyId)
        {
            try
            {
                TransControllerExt.DelTransnUpdBill(db, id, companyId);
                db.SaveChanges();
                var response = new
                {
                    status = 200,
                    transactionId = id,
                    msg = "Data Deleted Successfully"
                };
                return Json(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    status = 0,
                    msg = "Something Went Wrong",
                    error = new Exception(ex.Message, ex.InnerException)
                };
                return Ok(response);
            }
        }
        [HttpGet("GetPendingBills")]
        public IActionResult GetPendingBills(JObject objData)
        {
            try
            {
                dynamic jsonObj = objData;
                int? searchContactId = jsonObj.searchContactId;
                DateTime? uptoDate = jsonObj.uptoDate;
                int companyId = jsonObj.companyId;
                int? storeID = jsonObj.storeID;
                int? numRecords = jsonObj.numRecords;
                string UserID = jsonObj.UserID;

                SqlConnection sqlCon = new SqlConnection(Configuration.GetConnectionString("myconn"));
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("dbo.BillsByVendorIndex", sqlCon);
                cmd.Parameters.Add(new SqlParameter("@searchContactId", searchContactId));
                cmd.Parameters.Add(new SqlParameter("@uptoDate", uptoDate));
                cmd.Parameters.Add(new SqlParameter("@storeID", storeID));
                cmd.Parameters.Add(new SqlParameter("@numRecords", numRecords + 1));
                cmd.Parameters.Add(new SqlParameter("@userId", UserID));
                cmd.Parameters.Add(new SqlParameter("@companyId", companyId));

                SqlDataAdapter sqlAdp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                sqlAdp.Fill(ds);
                DataTable table = ds.Tables[0];
                var response = new
                {
                    status = 200,
                    pendingBills = table
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    status = 0,
                    msg = "Something Went Wrong",
                    error = new Exception(ex.Message, ex.InnerException)
                };
                return Ok(response);
            }
        }
    }
}
