﻿using System;
using System.Collections.Generic;

#nullable disable

namespace prjProduct_core.Models
{
    public partial class Coupon
    {
        public Coupon()
        {
            CouponDetails = new HashSet<CouponDetail>();
            Qquestionnaires = new HashSet<Qquestionnaire>();
        }

        public int CouponId { get; set; }
        public string CouponName { get; set; }
        public decimal Money { get; set; }
        public int Condition { get; set; }
        public DateTime CouponStartDate { get; set; }
        public DateTime CouponDeadline { get; set; }

        public virtual ICollection<CouponDetail> CouponDetails { get; set; }
        public virtual ICollection<Qquestionnaire> Qquestionnaires { get; set; }
    }
}
