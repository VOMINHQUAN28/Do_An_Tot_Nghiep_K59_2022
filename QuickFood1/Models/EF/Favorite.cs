//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuickFood.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Favorite
    {
        public long ID { get; set; }
        public Nullable<long> Food_ID { get; set; }
        public Nullable<long> User_ID { get; set; }
    
        public virtual Food Food { get; set; }
        public virtual User User { get; set; }
    }
}
