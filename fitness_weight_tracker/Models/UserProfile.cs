//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fitness_weight_tracker.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserProfile
    {
        public int ProfileID { get; set; }
        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Nullable<decimal> UserWeight { get; set; }
        public Nullable<decimal> UserHeight { get; set; }
        public Nullable<int> Age { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
