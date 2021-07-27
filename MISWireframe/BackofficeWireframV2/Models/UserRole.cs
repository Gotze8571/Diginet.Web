using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BackofficeWireframV2.Models
{
    public class UserRole
    {
        [Key]
        public int ID { get; set; }
        public string UserRole_Name { get; set; }
        public int CustomerType_ID { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public int Is_Active { get; set; }
        public DateTime Created_Date { get; set; }
        public int Updated_By { get; set; }
        public DateTime Updated_Date { get; set; }
    }
}