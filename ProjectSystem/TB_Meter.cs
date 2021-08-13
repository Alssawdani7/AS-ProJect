//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_Meter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Meter()
        {
            this.TB_Customer = new HashSet<TB_Customer>();
            this.TB_Read = new HashSet<TB_Read>();
            this.TB_LogCustomer = new HashSet<TB_LogCustomer>();
        }
    
        public int meter_id { get; set; }
        public Nullable<int> meter_no { get; set; }
        public Nullable<int> centerMeter_id { get; set; }
        public Nullable<int> sub_id { get; set; }
        public Nullable<double> meter_read { get; set; }
        public Nullable<bool> meter_status { get; set; }
    
        public virtual TB_CenterMeter TB_CenterMeter { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Customer> TB_Customer { get; set; }
        public virtual TB_Subscription TB_Subscription { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Read> TB_Read { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_LogCustomer> TB_LogCustomer { get; set; }
    }
}
