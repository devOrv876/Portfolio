using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class CVContext:DbContext
    {
        public DbSet<PersonalStatment> personalstatment { get; set; }
        public DbSet<Institution> institution { get; set; }

    }
}