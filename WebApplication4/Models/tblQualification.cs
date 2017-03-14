namespace Portfolio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblQualification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Qual_ID { get; set; }

        public string Qualification { get; set; }

        public string Module { get; set; }

        public string ModuleDetail { get; set; }

        [StringLength(255)]
        public string Grade { get; set; }

        public int? EduLevel_ID { get; set; }

        public int? Inst_ID { get; set; }

        public virtual tblEducationLevel tblEducationLevel { get; set; }

        public virtual tblInstitution tblInstitution { get; set; }
    }
}
