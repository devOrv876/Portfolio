using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    [Table("PersonalStatment")]
    public class PersonalStatmentModel
    {
        public int iD { get; set; }
        public string PStatment { get; set; }

    }
}