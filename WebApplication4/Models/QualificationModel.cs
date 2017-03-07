using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    [Table("Qualification")]
    public class QualificationModel  
   
    {
        [Key]
        public int Qual_ID { get; set; }
        public string qualification { get; set; }
        public string module { get; set; }
        public string moduleDetail { get; set; }
        public string grade { get; set; }
        public List<EducationModel> eduLevel_ID { get; set; }
        public List<InstitutionModel> inst_ID { get; set; }

    }
}