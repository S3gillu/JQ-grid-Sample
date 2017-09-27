using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using JQGRIDSAMPLE.Models;

namespace JQGRIDSAMPLE.Controllers
{
    public class EMPLOYEEController : Controller
    {
        public ActionResult EmployeeEDetails()
        {
            return View();
        }


        //Create

        [HttpPost]
        public string Create([Bind(Exclude = "Id")] MEmployeee Model)
        {
            ContextClass db = new ContextClass();
            string msg;
            try
            {
                if (ModelState.IsValid)
                {
                    Model.ID = Guid.NewGuid().ToString();
                    db.MEmployees.Add(Model);
                    db.SaveChanges();
                    msg = "Saved Successfully";
                }
                else
                {
                    msg = "Validation data not successfully";
                }
            }
            catch (Exception ex)
            {
                msg = "Error occured:" + ex.Message;
            }
            return msg;
        }

    }

}
