//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BacLabServer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Microorganisms_groups
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Microorganisms_groups()
        {
            this.Microorganisms = new HashSet<Microorganism>();
            this.p_AB_MO_group_profile = new HashSet<p_AB_MO_group_profile>();
        }
    
        public int id { get; set; }
        public string microorganisms_groups1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Microorganism> Microorganisms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<p_AB_MO_group_profile> p_AB_MO_group_profile { get; set; }
    }
}
