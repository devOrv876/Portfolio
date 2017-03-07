using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    [Table("EducationLevel")]
    public class EducationModel

    {
        [Key]
        public int eduLevel_ID { get; set; }
        public string eduLevel { get; set; }

    }
}