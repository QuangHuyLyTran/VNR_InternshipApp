using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VNR_InternShipApp.Models
{
    public class MonHoc
    {
        public int ID { get; set; }
        public string TenMonHoc { get; set; }
        public string MoTa { get; set; }
        public int KhoaHocID { get; set; }

        public virtual KhoaHoc KhoaHoc { get; set; }
    }
}