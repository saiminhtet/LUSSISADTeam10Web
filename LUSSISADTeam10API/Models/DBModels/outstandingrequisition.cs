//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LUSSISADTeam10API.Models.DBModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class outstandingrequisition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public outstandingrequisition()
        {
            this.outstandingrequisitiondetails = new HashSet<outstandingrequisitiondetail>();
        }
    
        public int outreqid { get; set; }
        public int reqid { get; set; }
        public string reason { get; set; }
        public int status { get; set; }
    
        public virtual requisition requisition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<outstandingrequisitiondetail> outstandingrequisitiondetails { get; set; }
    }
}
