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
    
    public partial class CustomerAddress
    {
        public CustomerAddress()
        {
            this.Customers = new HashSet<Customer>();
            this.Customers1 = new HashSet<Customer>();
        }
    
        public int Id { get; set; }
        public string address1 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
    
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Customer> Customers1 { get; set; }
    }
}
