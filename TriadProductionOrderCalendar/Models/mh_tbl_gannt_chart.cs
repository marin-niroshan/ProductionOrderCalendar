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
    
    public partial class mh_tbl_gannt_chart
    {
        public decimal prod_order_number { get; set; }
        public string comment { get; set; }
        public string project_manager { get; set; }
        public string quoted_hours { get; set; }
        public string est_ship_date { get; set; }
        public string assembler { get; set; }
        public string name { get; set; }
        public string job_name { get; set; }
        public string complete { get; set; }
        public decimal source_location_id { get; set; }
        public string printed { get; set; }
        public Nullable<System.DateTime> release_date { get; set; }
        public System.DateTime order_date { get; set; }
        public System.DateTime required_date { get; set; }
        public Nullable<decimal> location_id { get; set; }
        public Nullable<decimal> qty_requested { get; set; }
        public Nullable<decimal> qty_allocated { get; set; }
        public Nullable<decimal> qty_on_pick_tickets { get; set; }
        public Nullable<decimal> qty_confirmed { get; set; }
        public Nullable<decimal> perc_ready { get; set; }
        public Nullable<decimal> total_labor { get; set; }
        public string labor_perc_complete { get; set; }
    }
}
