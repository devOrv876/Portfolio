namespace Portfolio.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11_Context")
        {

        }

        public virtual DbSet<tblEducationLevel> tblEducationLevels { get; set; }
        public virtual DbSet<tblInstitution> tblInstitutions { get; set; }
        public virtual DbSet<tblPersonalStatement> tblPersonalStatements { get; set; }
        public virtual DbSet<tblQualification> tblQualifications { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblEducationLevel>()
                .Property(e => e.EduLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblInstitution>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tblInstitution>()
                .Property(e => e.InstitutionAddress)
                .IsUnicode(false);

            modelBuilder.Entity<tblPersonalStatement>()
                .Property(e => e.Statement)
                .IsUnicode(false);

            modelBuilder.Entity<tblQualification>()
                .Property(e => e.Qualification)
                .IsUnicode(false);

            modelBuilder.Entity<tblQualification>()
                .Property(e => e.Module)
                .IsUnicode(false);

            modelBuilder.Entity<tblQualification>()
                .Property(e => e.ModuleDetail)
                .IsUnicode(false);

            modelBuilder.Entity<tblQualification>()
                .Property(e => e.Grade)
                .IsUnicode(false);
        }
    }
}
