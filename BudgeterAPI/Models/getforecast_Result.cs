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
    
    public partial class getforecast_Result
    {
        public Nullable<System.DateTime> CALDATE { get; set; }
        public Nullable<decimal> TOTAL_PAYMENTS { get; set; }
        public string PAYMENTS_DETAIL { get; set; }
        public Nullable<decimal> TOTAL_DEDUCTIONS { get; set; }
        public string DEDUCTIONS_DETAIL { get; set; }
        public Nullable<decimal> TOTAL_SAVINGS { get; set; }
        public string SAVINGS_DETAIL { get; set; }
    }
}
