//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhamaPOS_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class saleBatch
    {
        public saleBatch()
        {
            this.sales = new HashSet<sale>();
        }
    
        public long saleBatchId { get; set; }
        public System.DateTime saleDate { get; set; }
        public decimal subTotal { get; set; }
        public decimal discountedAmount { get; set; }
        public decimal grandTotal { get; set; }
        public System.DateTime entryDate { get; set; }
        public string entryBy { get; set; }
    
        public virtual ICollection<sale> sales { get; set; }
    }
}
