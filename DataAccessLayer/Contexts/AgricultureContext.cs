using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contexts
{
    public class AgricultureContext : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Burada Sql Serverda Oluşturacağımız Database'nin İsmini ve Erişim İçin Sertifika İzni Veriyoruz.
            optionsBuilder.UseSqlServer("server=DESKTOP-KI81GQD;database=DbAgriculture;integrated security= true;Trust server certificate=true");
        }
            public DbSet<Address> Addresses { get; set; }
            public DbSet<Contact> Contacts { get; set; }
            public DbSet<Image> Images { get; set; }    
            public DbSet<AnnounCemet> AnnounCemets { get; set; }
            public DbSet<Service> Services { get; set; }
            public DbSet<Team> Teams { get; set; }
            public DbSet<SocialMedia> SocialMedias { get; set; }
            public DbSet<About> Abouts { get; set; }
            public DbSet<Admin>  Admins { get; set; }

    
    }
}
