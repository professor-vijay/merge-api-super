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
    public class CreditTrxController : Controller
    {
        private POSDbContext db;
        BillTypeEnum billType = BillTypeEnum.Credit;

        public IConfiguration Configuration { get; }
        public CreditTrxController(POSDbContext contextOptions, IConfiguration configuration)
        {
            db = contextOptions;
            Configuration = configuration;
        }
        // GET: CreditTrxController
        [HttpGet("GetCreditTrx")]
        public ActionResult GetCreditTrx(int compId)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Configuration.GetConnectionString("myconn"));
                sqlCon.Open();

                SqlCommand cmd = new SqlCommand("dbo.GetCreditTrx", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CompanyId", compId));
                DataSet ds = new DataSet();
                SqlDataAdapter sqlAdp = new SqlDataAdapter(cmd);
                sqlAdp.Fill(ds);
                return Ok(ds.Tables[0]);
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
        [HttpPost("PayCredit")]
        public ActionResult PayCredit([FromBody] dynamic objData)
        {
            using (var scope = SQLExt.CreateTransScope())
            {
                try
                {

                    int companyId = objData.companyId;
                    int userId = objData.userId;
                    int? responsibleById = objData.responsibleById;
                    int amount = objData.amount;
                    int contactId = objData.contactId;
                    string creditType = objData.creditType;
                    bool isPlanned = false;
                    List<PlannedTrans> planTransList = null;
                    PlannedTrans planTrans = null;
                    bool debtError = false;



                    //DateTime transDate = FbBatterController.GetDateTimeSave(transDateStr, transTime);
                    Transaction trans = new Transaction();
                    trans = objData.ToObject<Transaction>();

                    bool isNegativeBalance = TransControllerExt.CreateTrans(
                        db, trans, getTransFlow(billType));
                    if (!isNegativeBalance)
                    {
                        Bill bill = TransControllerExt.CreateBillForTrans(
                            db, trans, (int)billType,  DateTime.Now);
                        BillTrans billTrans = new BillTrans(trans.Id, bill.BillId);
                        bill.ResponsibleById = responsibleById;
                        bill.DueDate = FormatExt.GetDateSave(Convert.ToString(trans.DueDate));
                        bill.CreditTypeStr = creditType;
                        var debt = db.Bills.Where(c => c.ProviderId == bill.ReceiverId && c.BillType == (int)BillTypeEnum.Debt && c.CompanyId == companyId).ToList();
                        if (debt.Count > 0) debtError = true;
                        planTransList = db.PlannedTrans.Where(p => p.ContactId == trans.ContactId && p.StoreId == trans.StoreId && p.Status.Code != "COM" && p.CompanyId == companyId).ToList();
                        if (planTransList.Count > 0)
                        {
                            isPlanned = true;
                            planTrans = planTransList.FirstOrDefault();
                        }

                        billTrans.CompanyId = companyId;
                        db.BillTrans.Add(billTrans);
                        db.SaveChanges();
                        scope.Complete();
                    }
                    var data = new { isNegativeBalance = isNegativeBalance, isPlanned = isPlanned, debtError = debtError };
                    return Json(data);
                }
                catch (Exception e)
                {
                    var data = new { data = e.Message, msg = "Contact your service provider" };
                    return Json(data);
                }
            }
        }
        [HttpPost("Submit")]
        public ActionResult Submit([FromBody] dynamic objData)
        {
            try
            {
                int companyId = objData.companyId;
                int userId = objData.userId;
                Transaction trans = new Transaction();
                trans = objData.ToObject<Transaction>();
                JArray items = objData.items;
                dynamic creditArr = items.ToList();
                TransControllerExt.CreateTrans(db, trans, !getTransFlow(billType));
                TransControllerExt.BillnPays(db, creditArr, trans.Id, userId, companyId);
                db.SaveChanges();
                var response = new
                {
                    status = 200,
                    transactionId = trans.Id
                };
                return Json(response);
            }
            catch (Exception e)
            {
                var data = new { data = e.Message, msg = "Contact your service provider" };
                return Json(data);
            }
        }
        [HttpPost("UpdateCredit")]
        public ActionResult UpdateCredit([FromBody] JObject objData)
        {
            using (var scope = SQLExt.CreateTransScope())
            {
                try
                {
                    dynamic jsonObj = objData;
                    int companyId = jsonObj.companyId;
                    int? dbId = jsonObj.dbId;
                    int? responsibleById = jsonObj.responsibleById;
                    string creditType = jsonObj.creditType;

                    Transaction trans = jsonObj.trans.ToObject<Transaction>();

                    bool isNegBankBalance = TransControllerExt.UpdateTrans(db, trans, true, companyId);
                    bool isErrorInBillPayment = TransControllerExt.UpdateBillForTrans(db, trans, companyId, creditType, responsibleById);
                    db.SaveChanges();
                    scope.Complete();
                    var data = new { isNegBankBalance = isNegBankBalance, isErrorInBillPayment = isErrorInBillPayment, status = 1 };
                    return Json(data);
                }
                catch (Exception e)
                {
                    var data = new { data = e.Message, msg = "Contact your service provider", status = 0 };
                    return Json(data);
                }
            }
        }
        bool getTransFlow(BillTypeEnum billType)
        {
            if (billType == BillTypeEnum.Credit)
            {
                return false;
            }
            else if (billType == BillTypeEnum.Debt)
            {
                return true;
            }
            else
            {
                return true;
            }
        }
    }

}

