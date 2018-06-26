using LoanCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoanCalculator
{
    public class LoanBL
    {
        public void GetAmortization(LoanValue value)
        {
            LoanRepository db = new LoanRepository();

            value.Amortization = (value.Amount + value.Amount * value.Interest * value.Duration / 100) / (value.Duration * 1);

            value.Amortization = Math.Round(value.Amortization, 2);

            if (Double.IsNaN(value.Amortization))
            {
                value.Amortization = 0;
            }

            db.LoanValues.Add(value);
            db.SaveChanges();

            //bool isAmount = context.LoanValues
            //                  .Select(c => c.Amount).Contains(value.Amount);

            //bool isDuration = context.LoanValues
            //                  .Select(c => c.Duration).Contains(value.Duration);

            //bool isInterest= context.LoanValues
            //                  .Select(c => c.Interest).Contains(value.Interest);

            //if (isAmount & isDuration & isInterest)
            //{
            //    var data = (from l in context.LoanValues select l.Amount);
            //    value.Amount = Convert.ToDouble(data);

            //    data = (from l in context.LoanValues select l.Duration);
            //    value.Duration = Convert.ToDouble(data);

            //    data = (from l in context.LoanValues select l.Interest);
            //    value.Duration = Convert.ToDouble(data);




            //    var t = db.Database.ExecuteSqlCommand("SELECT * FROM [LoanValues] WHERE Amount =" + value.Amount.ToString() + "AND Duration =" + value.Duration.ToString() + "AND Interest =" + value.Interest.ToString());

            //    var n = db.Database.ExecuteSqlCommand("SELECT * FROM [LoanValues] WHERE NOT EXISTS (SELECT* FROM [LoanValues] WHERE Amount =" + value.Amount.ToString() + "AND Duration =" + value.Duration.ToString() + "AND Interest =" + value.Interest.ToString() + ")");

        }
    }
}
