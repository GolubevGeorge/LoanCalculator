using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LoanCalculator.Models
{
    public class LoanValue
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public double Duration { get; set; }
        public double Interest { get; set; }
        public double Amortization { get; set; }
    }

    public class LoanRepository : DbContext
    {
        public DbSet<LoanValue> LoanValues { get; set; }
    }
}