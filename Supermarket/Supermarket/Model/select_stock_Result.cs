//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Supermarket.Model
{
    using System;
    
    public partial class select_stock_Result
    {
        public int id { get; set; }
        public string product { get; set; }
        public string bar_code { get; set; }
        public string category { get; set; }
        public string producer { get; set; }
        public double quantity { get; set; }
        public double purchase_price { get; set; }
        public double selling_price { get; set; }
        public string name { get; set; }
        public System.DateTime supply_date { get; set; }
        public System.DateTime expiration_date { get; set; }
    }
}
