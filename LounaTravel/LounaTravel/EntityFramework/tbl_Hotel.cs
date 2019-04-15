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
    
    public partial class tbl_Hotel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Hotel()
        {
            this.tbl_ImageHotel = new HashSet<tbl_ImageHotel>();
            this.tbl_Convenient = new HashSet<tbl_Convenient>();
            this.tbl_Tour = new HashSet<tbl_Tour>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public Nullable<int> RoomNumber { get; set; }
        public Nullable<bool> isHot { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> Rating { get; set; }
        public bool isDelete { get; set; }
        public int CityID { get; set; }
        public Nullable<bool> isParking { get; set; }
        public Nullable<bool> isCredit { get; set; }
        public string Type { get; set; }
    
        public virtual tbl_City tbl_City { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ImageHotel> tbl_ImageHotel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Convenient> tbl_Convenient { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Tour> tbl_Tour { get; set; }
    }
}