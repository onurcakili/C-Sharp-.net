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
    
    public partial class Departmanlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Departmanlar()
        {
            this.Amirlers = new HashSet<Amirler>();
            this.Kayıtlar = new HashSet<Kayıtlar>();
            this.Personellers = new HashSet<Personeller>();
        }
    
        public int departmanID { get; set; }
        public string departmanAdi { get; set; }
        public Nullable<int> departmanBölge { get; set; }
        public Nullable<int> departmanAmiri { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Amirler> Amirlers { get; set; }
        public virtual Amirler Amirler { get; set; }
        public virtual Bölgeler Bölgeler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kayıtlar> Kayıtlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personeller> Personellers { get; set; }
    }
}