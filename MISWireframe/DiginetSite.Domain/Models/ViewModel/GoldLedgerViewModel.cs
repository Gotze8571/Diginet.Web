using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiginetSite.Domain.Models.ViewModel
{
    public class GoldLedgerViewModel
    {

        [Display(Name = "DATE")]
        public DateTime Date { get; set; }
        [Display(Name = "ACTIVITY")]
        public string Activity { get; set; }
        [Display(Name = "AMOUNT")]
        public double Amount { get; set; }
        [Display(Name = "VALUE")]
        public string Value { get; set; }
        [Display(Name = "STATUS")]
        public string Status { get; set; }
    }
}
