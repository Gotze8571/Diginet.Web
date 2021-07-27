using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiginetSite.Domain.Entity
{
    public class UserRole
    {
        [Key]
        public int ID { get; set; }
        public string UserRole_Name { get; set; }
        public string Description { get; set; }
        public int Is_Active { get; set; }
        public DateTime Creation_Date { get; set; }
        public int Updated_By { get; set; }
        public DateTime Updated_Date { get; set; }
    }
}
