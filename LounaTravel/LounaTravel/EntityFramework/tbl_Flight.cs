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
    
    public partial class tbl_Flight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Flight()
        {
            this.tbl_Tour = new HashSet<tbl_Tour>();
        }
    
        public string ID { get; set; }
        public System.DateTime DateGo { get; set; }
        public System.DateTime DateBack { get; set; }
        public string CodeGo { get; set; }
        public string CodeBack { get; set; }
        public System.DateTime DateGoArrival { get; set; }
        public System.DateTime DateBackArrival { get; set; }
        public bool isDelete { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Tour> tbl_Tour { get; set; }
    }
}
