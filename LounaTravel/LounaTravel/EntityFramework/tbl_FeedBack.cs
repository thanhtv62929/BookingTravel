//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LounaTravel.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_FeedBack
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_FeedBack()
        {
            this.tbl_ReplyBy = new HashSet<tbl_FeedBack>();
        }
    
        public int ID { get; set; }
        public string FeedBackContent { get; set; }
        public bool isDelete { get; set; }
        public Nullable<int> ReplyTo { get; set; }
        public string Username { get; set; }
        public string TourID { get; set; }
        public string AdminID { get; set; }
        public System.DateTime DateCreate { get; set; }
    
        public virtual tbl_Admin tbl_Admin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_FeedBack> tbl_ReplyBy { get; set; }
        public virtual tbl_FeedBack tbl_ReplyTo { get; set; }
        public virtual tbl_User tbl_User { get; set; }
        public virtual tbl_Tour tbl_Tour { get; set; }
    }
}
