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
    
    public partial class Antibiotic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Antibiotic()
        {
            this.p_AB_MO_group_profile = new HashSet<p_AB_MO_group_profile>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string abbreviated_us { get; set; }
        public string abbreviated_ru { get; set; }
        public Nullable<int> id_group_AB { get; set; }
    
        public virtual Antibiotics_groups Antibiotics_groups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<p_AB_MO_group_profile> p_AB_MO_group_profile { get; set; }
    }
}
