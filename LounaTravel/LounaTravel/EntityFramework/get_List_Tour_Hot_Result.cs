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
    
    public partial class get_List_Tour_Hot_Result
    {
        public string ID { get; set; }
        public System.DateTime TimeBegin { get; set; }
        public System.DateTime TimeEnd { get; set; }
        public double PriceForKid { get; set; }
        public double PriceForBaby { get; set; }
        public double PriceForAdult { get; set; }
        public string Vehicle { get; set; }
        public int TourGuideID { get; set; }
        public int SeatsRemaining { get; set; }
        public int TotalSeats { get; set; }
        public string Description { get; set; }
        public Nullable<int> IsSale { get; set; }
        public int TravelTypeID { get; set; }
        public int fromPlace { get; set; }
        public bool isDelete { get; set; }
        public Nullable<bool> isHot { get; set; }
        public Nullable<int> rating { get; set; }
        public string FlightID { get; set; }
        public string GroupUpPlace { get; set; }
        public System.DateTime GroupUpTime { get; set; }
        public string MeetingPlace { get; set; }
        public Nullable<System.DateTime> MeetingTime { get; set; }
        public string Note { get; set; }
        public string Name { get; set; }
    }
}