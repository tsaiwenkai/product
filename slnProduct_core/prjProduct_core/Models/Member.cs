﻿using System;
using System.Collections.Generic;

#nullable disable

namespace prjProduct_core.Models
{
    public partial class Member
    {
        public Member()
        {
            Comments = new HashSet<Comment>();
            CouponDetails = new HashSet<CouponDetail>();
            MyLikes = new HashSet<MyLike>();
            Orders = new HashSet<Order>();
            Qquestionnaires = new HashSet<Qquestionnaire>();
        }

        public string MemberPhone { get; set; }
        public int MemberId { get; set; }
        public int ShoppingCarId { get; set; }
        public string MemberEmail { get; set; }
        public string MemberPassword { get; set; }
        public string MemberAddress { get; set; }
        public string MemberName { get; set; }
        public DateTime MemberBirthDay { get; set; }
        public byte[] MemberPhoto { get; set; }
        public bool? BlackList { get; set; }

        public virtual ShoppingCar ShoppingCar { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<CouponDetail> CouponDetails { get; set; }
        public virtual ICollection<MyLike> MyLikes { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Qquestionnaire> Qquestionnaires { get; set; }
    }
}
