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
    
    public partial class Review
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public System.DateTime DateOfVisit { get; set; }
        public System.DateTime DateOfPost { get; set; }
        public int Rating { get; set; }
    
        public virtual Customer Customers { get; set; }
    }
}