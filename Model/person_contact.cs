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
    
    public partial class person_contact
    {
        public int contactID { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public string message { get; set; }
        public int userID { get; set; }
        public Nullable<bool> isRead { get; set; }
        public Nullable<bool> isDelete { get; set; }
        public Nullable<System.DateTime> addTime { get; set; }
        public Nullable<System.DateTime> updateTime { get; set; }
    }
}
