//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StorIS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Postavka
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Postavka()
        {
            this.Sostav_postavki = new HashSet<Sostav_postavki>();
        }
    
        public int ID_поставки { get; set; }
        public string Дата { get; set; }
        public int ID_поставщика { get; set; }
        public int Номер_поставки { get; set; }
    
        public virtual Postavshik Postavshik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sostav_postavki> Sostav_postavki { get; set; }
    }
}
