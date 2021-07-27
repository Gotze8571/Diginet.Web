using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiginetSite.Domain.Entity
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public string ExternalSystem_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int CustomerType_ID { get; set; }
        public int Rank_ID { get; set; }
        public DateTime Join_Date { get; set; }
        public int WebhookResponse_ID { get; set; }
        public int Is_Active { get; set; }
        public DateTime Creation_Date { get; set; }
        public int Updated_By { get; set; }
        public DateTime Updated_Date { get; set; }
    }
}
