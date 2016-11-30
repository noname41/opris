using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppAspnet.Database
{
    public class Class1
    {
        public class Company
        {
            public int Id { get; set; }
            public string PersonName { get; set; }
            public string PersonSurname { get; set; }
            public string PersonSecname { get; set; }
            public string companyName { get; set; }
            public int companyPackage { get; set; }
            public string companyPhone { get; set; }
            public string companySite { get; set; }
            public string companyAdress { get; set; }
            public string companyMail { get; set; }
            public string companyInfo { get; set; }
            public string companyFax { get; set; }
            public DateTime companyEndDate { get; set; }
        }

        public class Ads
        {
            public int id_Ad { get; set; }
            public string adTitle { get; set; }
            public string id_Rubric { get; set; }
            public string adtext { get; set; }
            public DateTime adDatePublic { get; set; }
            public string adConfirm { get; set; }
        }

        public class User
        {
            public int Id { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }

        public class CompanyContext : DbContext
        {
            public DbSet<Company> Company { get; set; }
            public DbSet<Ads> Ads { get; set; }
            public DbSet<User> User { get; set; }
        }
    }
}