using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using SuperMarketApi.Models;
using SuperMarketApi.Models.Enum;


namespace SuperMarketApi.Controllers
{
    [Route("api/[controller]")]
    public class PurchaseController : Controller
    {
        private POSDbContext db;
        public IConfiguration Configuration { get; }
        public PurchaseController(POSDbContext contextOptions, IConfiguration configuration)
        {
            db = contextOptions;
            Configuration = configuration;
        }
        // GET: PurchaseController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PurchaseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PurchaseController/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost("GetPurchaseTrx")]
        public IActionResult GetPurchaseTrx([FromBody] dynamic objData)
        {
            try
            {
                dynamic jsonObj = objData;
                int companyId = jsonObj[0].companyId;
                int? receiverStoreId = jsonObj[0].receiverStoreId;
                int? searchContactId = jsonObj[0].searchContactId;
                int? billId = jsonObj[0].billId;
                string billStatus = jsonObj[0].billstatus;
                int? UserID = jsonObj[0].UserID;
                int? numRecords = jsonObj[0].numRecords;
                int? amountFrom = jsonObj[0].amountFrom;
                int? amountUpto = jsonObj[0].amountUpto;
                int? sessionStoreID = jsonObj[0].sessionStoreID;
                DateTime? dateFrom = jsonObj[0].dateFrom;
                DateTime? dateTo = DateTime.Now;

                SqlConnection sqlCon = new SqlConnection(Configuration.GetConnectionString("myconn"));
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("dbo.PurchaseIndex", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@receiverStoreId", receiverStoreId));
                cmd.Parameters.Add(new SqlParameter("@searchContactId", searchContactId));
                cmd.Parameters.Add(new SqlParameter("@billId", billId));
                cmd.Parameters.Add(new SqlParameter("@billStatus", billStatus));
                cmd.Parameters.Add(new SqlParameter("@fromDate", dateFrom));
                cmd.Parameters.Add(new SqlParameter("@toDate", dateTo));
                cmd.Parameters.Add(new SqlParameter("@sessionStoreID", 0));
                cmd.Parameters.Add(new SqlParameter("@userId", UserID));
                cmd.Parameters.Add(new SqlParameter("@numRecords", numRecords));
                cmd.Parameters.Add(new SqlParameter("@amountFrom", amountFrom));
                cmd.Parameters.Add(new SqlParameter("@amountUpto", amountUpto));
                cmd.Parameters.Add(new SqlParameter("@companyId", companyId));
                //cmd.CommandTimeout = 0;
                //DataTable dt = new DataTable();

                DataSet ds = new DataSet();
                SqlDataAdapter sqlAdp = new SqlDataAdapter(cmd);
                sqlAdp.Fill(ds);
                //DataTable table = ds.Tables[0];

                var response = new
                {
                    Ord = ds.Tables[0]
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    status = 200,
                    msg = "Something went wrong",
                    error = new Exception(ex.Message, ex.InnerException)
                };
                return Ok(response);
            }
        }


        [HttpPost("Purchase")]
        public IActionResult Purchase([FromBody] dynamic payload)
        {
            try
            {
                Order order = new Order();
                order = payload.toObject<Order>();
                db.Orders.Add(order);
                db.SaveChanges();
                var response = new
                {
                    status = 200,
                    message = "Purchase Item Added Successfull"
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    status  = 0,
                    msg = "Something Went Wrong",
                    error = new Exception(ex.Message, ex.InnerException)
                };
                return Ok(response);
            }
        }

        // POST: PurchaseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PurchaseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PurchaseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PurchaseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PurchaseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
