//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class person_contact_info
    {
        public int contactInfoID { get; set; }
        public string phoneOne { get; set; }
        public string phoneTwo { get; set; }
        public string emailOne { get; set; }
        public string emailTwo { get; set; }
        public string address { get; set; }
        public string area { get; set; }
        public Nullable<int> userID { get; set; }
        public Nullable<System.DateTime> addTime { get; set; }
        public Nullable<System.DateTime> updateTime { get; set; }
    }
}
