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
    
    public partial class Employee : User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.WorkSchedules = new HashSet<WorkSchedule>();
        }
    
        public string Availability { get; set; }
        public string HoursPerWeek { get; set; }
        public Nullable<int> PayRate { get; set; }
        public Nullable<int> Salary { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkSchedule> WorkSchedules { get; set; }
    }
}
