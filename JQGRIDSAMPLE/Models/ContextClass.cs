using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JQGRIDSAMPLE.Models
{
    public class ContextClass : DbContext
    {

        public ContextClass()
                    : base("Emp")
        {
        }
        public DbSet<MEmployeee> MEmployees { get; set; }
    }
}