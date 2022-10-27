using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomilyNETTest.Models
{
    public class DateLog
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}