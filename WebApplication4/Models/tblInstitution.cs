namespace Portfolio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblInstitution
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblInstitution()
        {
            tblQualifications = new HashSet<tblQualification>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Inst_ID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public DateTime? StudyDate { get; set; }

        public string InstitutionAddress { get; set; }

        public int? EduLevel_ID { get; set; }

        public virtual tblEducationLevel tblEducationLevel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblQualification> tblQualifications { get; set; }
    }
}
