//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime MondayStart { get; set; }
        public System.DateTime TuesdayStart { get; set; }
        public System.DateTime WednesdayStart { get; set; }
        public System.DateTime ThursdayStart { get; set; }
        public System.DateTime FridayStart { get; set; }
        public System.DateTime SaturdayStart { get; set; }
        public System.DateTime SundayStart { get; set; }
        public System.DateTime MondayEnd { get; set; }
        public System.DateTime TuesdayEnd { get; set; }
        public System.DateTime WednesdayEnd { get; set; }
        public System.DateTime ThursdayEnd { get; set; }
        public System.DateTime FridayEnd { get; set; }
        public System.DateTime SaturdayEnd { get; set; }
        public System.DateTime SundayEnd { get; set; }
        public string Description { get; set; }
        public string Cuisine { get; set; }
    }
}