//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LYZJ.HM3Shop.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActionGroup
    {
        public ActionGroup()
        {
            this.ActionInfo = new HashSet<ActionInfo>();
            this.UserInfo = new HashSet<UserInfo>();
            this.Role = new HashSet<Role>();
        }
    
        public int ID { get; set; }
        public string GroupName { get; set; }
        public short DelFlag { get; set; }
        public short GroupType { get; set; }
    
        public virtual ICollection<ActionInfo> ActionInfo { get; set; }
        public virtual ICollection<UserInfo> UserInfo { get; set; }
        public virtual ICollection<Role> Role { get; set; }
    }
}
