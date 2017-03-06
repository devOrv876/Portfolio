using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    [Table("EducationLevel")]
    public class EducationLevel
    {
        public int eduLevel_ID { get; set; }
        public string eduLevel { get; set; }
    }
    [Table("Institution")]
    public class Institution
    {
        public int inst_ID { get; set; }
        public string name { get; set; }
        public DateTime studyDate { get; set; }
        public string institutionAddress { get; set; }
        public virtual EducationLevel eduLevel_ID { get; set; }

    }
    [Table("PersonalStatment")]
    public class PersonalStatment
    {
        public int iD { get; set; }
        public string personalStatment { get; set; }

    }
    [Table("Qualification")]
    public class Qualification
    {
        public int qual_ID { get; set; }
        public string qualification { get; set; }
        public string module { get; set; }
        public string moduleDetail { get; set; }
        public string grade { get; set; }
        public virtual EducationLevel eduLevel_ID { get; set; }
        public virtual Institution inst_ID { get; set; }
        
    }

}