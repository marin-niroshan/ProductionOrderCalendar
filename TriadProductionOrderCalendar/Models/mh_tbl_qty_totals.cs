//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TriadProductionOrderCalendar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class mh_tbl_qty_totals
    {
        public decimal prod_order_number { get; set; }
        public Nullable<decimal> qty_requested { get; set; }
        public Nullable<decimal> qty_allocated { get; set; }
        public Nullable<decimal> qty_on_pick_tickets { get; set; }
        public Nullable<decimal> qty_confirmed { get; set; }
        public Nullable<decimal> perc_ready { get; set; }
    }
}
