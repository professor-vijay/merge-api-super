using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SuperMarketApi.Models;

namespace SuperMarketApi.Controllers
{
    [Route("api/[controller]")]
    public class SaleController : Controller
    {
        private POSDbContext db;
        public IConfiguration Configuration { get; }
        private static TimeZoneInfo India_Standard_Time = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        public SaleController(POSDbContext contextOptions, IConfiguration configuration)
        {
            db = contextOptions;
            Configuration = configuration;
        }
        // GET: SaleController
        [HttpPost("saveorder")]
        public IActionResult saveorder([FromBody] dynamic payload)
        {
            int line = 28;
            try
            {
                Customer customer = new Customer();
                Order order = new Order(); line++;
                order = payload.ToObject<Order>(); line++;
                string cphone = payload.CustomerDetails.PhoneNo.ToString();
                if (db.Customers.Where(x => x.PhoneNo == cphone).AsNoTracking().Any())
                {
                    payload.CustomerDetails.Id = db.Customers.Where(x => x.PhoneNo == cphone).AsNoTracking().FirstOrDefault().Id;
                    customer = payload.CustomerDetails.ToObject<Customer>();
                    customer.CompanyId = order.CompanyId;
                    customer.StoreId = order.StoreId;
                    db.Entry(customer).State = EntityState.Modified; line++;
                    db.SaveChanges();
                    order.CustomerId = customer.Id;
                }
                else if (cphone != "" && cphone != null)
                {
                    payload.CustomerDetails.Id = 0;
                    customer = payload.CustomerDetails.ToObject<Customer>();
                    customer.CompanyId = order.CompanyId;
                    customer.StoreId = order.StoreId;
                    db.Customers.Add(customer);
                    db.SaveChanges();
                    order.CustomerId = customer.Id;
                }
                else
                {
                    order.CustomerId = null;
                }
                db.Orders.Add(order); line++;
                db.SaveChanges(); line++;
                List<Batch> batches = new List<Batch>(); line++;
                List<StockBatch> stockBatches = new List<StockBatch>(); line++;
                int batchno = db.Batches.Where(x => x.CompanyId == order.CompanyId).Max(x => x.BatchNo); line++;
                foreach (var item in payload.Items)
                {
                    batches = new List<Batch>(); line++;
                    stockBatches = new List<StockBatch>(); line++;
                    OrderItem orderItem = new OrderItem(); line++;
                    orderItem = item.ToObject<OrderItem>(); line++;
                    orderItem.OrderId = order.Id; line++;
                    db.OrderItems.Add(orderItem); line++;
                    db.SaveChanges(); line++;
                    batches = db.Batches.Where(x => x.BarcodeId == orderItem.BarcodeId && x.Price == orderItem.Price).ToList(); line++;
                    foreach (Batch batch in batches)
                    {
                        var sbatches = db.StockBatches.Where(x => x.BatchId == batch.BatchId && x.Quantity >= orderItem.OrderQuantity).ToList(); line++;
                        foreach (StockBatch stockBatch in sbatches)
                        {
                            stockBatches.Add(stockBatch); line++;
                        }
                    }
                    stockBatches = stockBatches.OrderBy(x => x.CreatedDate).ToList(); line++;
                    if (stockBatches.Count > 0)
                    {
                        StockBatch stckBtch = new StockBatch();
                        stckBtch = stockBatches.FirstOrDefault(); line++;
                        stckBtch.Quantity = stckBtch.Quantity - (int)orderItem.OrderQuantity; line++;
                        db.Entry(stckBtch).State = EntityState.Modified; line++;
                        db.SaveChanges(); line++;
                    }
                }
                int lastorderno = db.Orders.Where(x => x.StoreId == order.StoreId).Max(x => x.OrderNo); line++;
                var response = new
                {
                    status = 200,
                    message = "Sales Added Successfully",
                    lastorderno = lastorderno,
                    batches = batches,
                    stockBatches = stockBatches,
                    customer = customer
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    status = 0,
                    msg = "Something Went Wrong",
                    error = new Exception(ex.Message, ex.InnerException),
                    errorline = line
                };
                return Ok(response);
            }
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: SaleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SaleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SaleController/Create
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

        // GET: SaleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SaleController/Edit/5
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

        // GET: SaleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SaleController/Delete/5
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
