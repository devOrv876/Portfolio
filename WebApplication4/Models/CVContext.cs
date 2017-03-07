using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace WebApplication4.Models
{
    public class CVContext:DbContext
    {
        public DbSet<PersonalStatmentModel> personalstatment {
            get; set; }
        public DbSet<InstitutionModel> institution { get; set; }
        public DbSet<EducationModel> education { get; set; }
        //public DbSet<QualificationModel> dbQual { get; set; }

    }
}