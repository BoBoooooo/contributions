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
    
    public partial class Resource
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> HandleDept { get; set; }
        public Nullable<System.Guid> HandleStaff { get; set; }
        public Nullable<System.Guid> TypeId { get; set; }
        public string ResName { get; set; }
        public string ResDesc { get; set; }
        public string Keyword { get; set; }
        public string HandleDate { get; set; }
        public Nullable<int> ResLevel { get; set; }
        public string Status { get; set; }
        public string ResAttr { get; set; }
        public string TableName { get; set; }
        public Nullable<int> ViewCount { get; set; }
        public Nullable<int> DownloadCount { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}
