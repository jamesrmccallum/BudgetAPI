//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BudgeterAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class frequency
    {
        public frequency()
        {
            this.Payments_deductions = new HashSet<Payments_deductions>();
        }
    
        public byte ID { get; set; }
        public string Frequency_description { get; set; }
    
        public virtual ICollection<Payments_deductions> Payments_deductions { get; set; }
    }
}
