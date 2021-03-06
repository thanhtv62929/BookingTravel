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
    
    public partial class tbl_Booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Booking()
        {
            this.tbl_Passenger = new HashSet<tbl_Passenger>();
        }
    
        public int BookingID { get; set; }
        public Nullable<double> TotalMoney { get; set; }
        public System.DateTime DateCreate { get; set; }
        public string Username { get; set; }
        public bool isDelete { get; set; }
        public Nullable<int> NumOfKid { get; set; }
        public string Note { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string TourID { get; set; }
        public int NumOfAdult { get; set; }
        public Nullable<int> NumOfBaby { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string Email { get; set; }
    
        public virtual tbl_User tbl_User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Passenger> tbl_Passenger { get; set; }
        public virtual tbl_Tour tbl_Tour { get; set; }
    }
}
