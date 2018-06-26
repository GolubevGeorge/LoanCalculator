using LoanCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoanCalculator.Controllers
{
    public class LoanController : ApiController
    {
        LoanRepository db = new LoanRepository();
        LoanBL loanBL = new LoanBL();

        public IEnumerable<LoanValue> Get()
        {
            return db.LoanValues;
        }

        [HttpPost]
        public void CreateEntry([FromBody]LoanValue value)
        {
            loanBL.GetAmortization(value);
        }

        [HttpDelete]
        public void DeleteAll()
        {
            db.Database.ExecuteSqlCommand("DELETE FROM [LoanValues]");
            db.SaveChanges();
            }
        }
    }
