using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{

    [Table("PersonalStatment")]
    public class PersonalStatment
    {

        public PersonalStatment()
        {
        }

        [Key]
        public int iD { get; set; }
        public string PStatment { get; set; }

    }


    [Table("EducationLevel")]
    public class EducationLevel
    {
        public EducationLevel()
        {
            //Institutions = new HashSet<Institution>();
            //Qualifications = new HashSet<Qualification>();
        }

        [Key]
        public int eduLevel_ID { get; set; }
        public string eduLevel { get; set; }

    }

    [Table("Institution")]
    public class Institution
    {

        public Institution()
        {
            //Qualifications = new HashSet<Qualification>();

        }

        [Key]
        public int inst_ID { get; set; }
        public string name { get; set; }
        public DateTime studyDate { get; set; }
        public string institutionAddress { get; set; }
        public int? EduLevel_ID { get; set; }

        //-----------
        public virtual EducationLevel EducationLevels { get; set; }

    }


    [Table("Qualification")]
    public class Qualification
    {

        public Qualification()
        {
        }
        [Key]
        public int qual_ID { get; set; }
        public string qualification { get; set; }
        public string module { get; set; }
        public string moduleDetail { get; set; }
        public string grade { get; set; }
        public int? EduLevel_ID { get; set; }
        public int? Inst_ID { get; set; }
        //Foriegn Keys           
        public virtual EducationLevel EducationLevels { get; set; }
        public virtual Institution Institutions { get; set; }


    }


}
