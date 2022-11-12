using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanHangMain.Models
{
    public abstract class CommonAbstract
    {
        public string CreateBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }
    }
}