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
    
    public partial class Staff
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int id_category { get; set; }
        public Nullable<System.DateTime> birthday { get; set; }
        public string adress { get; set; }
        public string telephon { get; set; }
    
        public virtual Staff_category Staff_category { get; set; }
    }
}