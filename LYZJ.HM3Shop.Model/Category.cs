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
    
    public partial class Category
    {
        public Category()
        {
            this.Property = new HashSet<Property>();
            this.GoodInfo = new HashSet<GoodInfo>();
        }
    
        public int ID { get; set; }
        public string CatName { get; set; }
        public short DelFlag { get; set; }
        public int ParentID { get; set; }
        public string TreePath { get; set; }
        public int Level { get; set; }
        public short IsLeaf { get; set; }
    
        public virtual ICollection<Property> Property { get; set; }
        public virtual ICollection<GoodInfo> GoodInfo { get; set; }
    }
}
