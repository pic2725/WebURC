using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace URC_final.Models
{
    public class OpportunityViews
    {
        [Key]
        public int OpportunityID { get; set; }
        public int Mon { get; set; }
        public int Tue { get; set; }
        public int Wen { get; set; }
        public int Thr { get; set; }
        public int Fri { get; set; }
        public int Sat { get; set; }
        public int Sun { get; set; }
    }
}