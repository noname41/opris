//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppAspnet.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_Company()
        {
            this.Table_Ads = new HashSet<Table_Ads>();
        }
    
        public int id_Company { get; set; }
        public string companyPersonName { get; set; }
        public string companyPersonSurname { get; set; }
        public string companyPersonSecName { get; set; }
        public string companyName { get; set; }
        public string companyPackage { get; set; }
        public int companyPhone { get; set; }
        public string companyAdress { get; set; }
        public string companySite { get; set; }
        public string companyMail { get; set; }
        public Nullable<int> companyFax { get; set; }
        public string companyInfo { get; set; }
        public Nullable<System.DateTime> companyPackEndDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Ads> Table_Ads { get; set; }
    }
}
