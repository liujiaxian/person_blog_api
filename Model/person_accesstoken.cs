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
    
    public partial class person_accesstoken
    {
        public int ID { get; set; }
        public string access_token { get; set; }
        public Nullable<int> expires_in { get; set; }
        public string refresh_token { get; set; }
        public Nullable<System.DateTime> updateTime { get; set; }
    }
}