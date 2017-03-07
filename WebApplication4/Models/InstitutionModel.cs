using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    [Table("Institution")]
    public class InstitutionModel
    {
        [Key]
        public int inst_ID { get; set; }
        public string name { get; set; }
        public DateTime studyDate { get; set; }
        public string institutionAddress { get; set; }
        public List <EducationModel> eduLevel_ID { get; set; }
    }
    
}