//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PoliceDepartment
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ekip_Araclari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ekip_Araclari()
        {
            this.Personellers = new HashSet<Personeller>();
        }
    
        public int aracID { get; set; }
        public string aracPlaka { get; set; }
        public Nullable<int> aracPersonel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personeller> Personellers { get; set; }
    }
}
