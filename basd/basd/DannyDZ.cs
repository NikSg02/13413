//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace basd
{
    using System;
    using System.Collections.Generic;
    
    public partial class DannyDZ
    {
        public int IdContract { get; set; }
        public string NumberContract { get; set; }
        public int IdSuppler { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
    
        public virtual Supplier Supplier { get; set; }
        public virtual DannyS DannyS { get; set; }
    }
}