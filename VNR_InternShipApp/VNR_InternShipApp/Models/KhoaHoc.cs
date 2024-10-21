using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VNR_InternShipApp.Models
{
        public class KhoaHoc
        {
            public int ID { get; set; }
            public string TenKhoaHoc { get; set; }

            public virtual ICollection<MonHoc> MonHocs { get; set; }
        }

 }