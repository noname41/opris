//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppAspnet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Table_Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_Company()
        {
            this.Table_Users = new HashSet<Table_Users>();
            this.Table_Ads = new HashSet<Table_Ads>();
        }
        [Display(Name = "Номер компании")]
        public int id_Company { get; set; }
        [Display(Name = "Имя")]
        public string companyPersonName { get; set; }
        [Display(Name = "Фамилия")]
        public string companyPersonSurname { get; set; }
        [Display(Name = "Отчество")]
        public string companyPersonSecName { get; set; }
        [Display(Name = "Название компании")]
        public string companyName { get; set; }
        [Display(Name = "Пакет компании")]
        public string companyPackage { get; set; }
        [Display(Name = "Телефон")]
        public int companyPhone { get; set; }
        [Display(Name = "Адрес")]
        public string companyAdress { get; set; }
        [Display(Name = "Веб-сайт")]
        public string companySite { get; set; }
        [Display(Name = "Электронная почта")]
        public string companyMail { get; set; }
        [Display(Name = "Факс")]
        public Nullable<int> companyFax { get; set; }
        [Display(Name = "Информация о компании")]
        public string companyInfo { get; set; }
        [Display(Name = "Окончание публикации объявления")]
        public Nullable<System.DateTime> companyPackEndDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Users> Table_Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Ads> Table_Ads { get; set; }
    }
}
