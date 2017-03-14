using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication4.Models;


namespace WebApplication4.Models
{
    public class CVContext:DbContext
    {

        public CVContext()
            : base("name=CVContext")
        {
            
        }


        public DbSet<Qualification> qualification { get; set; }
        public DbSet<PersonalStatment> personal { get; set; }
        public DbSet<Institution> institute { get; set; }
        public DbSet<EducationLevel> education { get; set; }



        //public DbSet<PersonalStatmentModel> personalstatment { get; set; }
        //public DbSet<InstitutionModel> institution { get; set; }
        //public DbSet<EducationModel> education { get; set; }

        //public DbSet<QualificationModel> dbQual { get; set; }


        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<EducationLevel>()
        //        .Property(e => e.eduLevel)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Institution>()
        //        .Property(e => e.name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Institution>()
        //        .Property(e => e.institutionAddress)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PersonalStatment>()
        //        .Property(e => e.PStatment)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Qualification>()
        //        .Property(e => e.qualification)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Qualification>()
        //        .Property(e => e.module)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Qualification>()
        //        .Property(e => e.moduleDetail)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Qualification>()
        //        .Property(e => e.grade)
        //        .IsUnicode(false);
        //}

    }

}