//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public int Id { get; set; }
        public string custCode { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public Nullable<int> petID { get; set; }
        public Nullable<int> billID { get; set; }
        public Nullable<int> shipID { get; set; }
    
        public virtual CustomerAddress CustomerAddress { get; set; }
        public virtual CustomerAddress CustomerAddress1 { get; set; }
        public virtual CustomerData CustomerData { get; set; }
    }
}
