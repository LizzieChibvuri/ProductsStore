using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Data
{
    public class Audit
    {
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
