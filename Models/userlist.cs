//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ListSwype.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class userlist
    {
        public int id { get; set; }
        public int userid { get; set; }
        public Nullable<int> listid { get; set; }
        public Nullable<int> customitemid { get; set; }
    
        public virtual commonlist commonlist { get; set; }
        public virtual customlist customlist { get; set; }
        public virtual user user { get; set; }
    }
}
