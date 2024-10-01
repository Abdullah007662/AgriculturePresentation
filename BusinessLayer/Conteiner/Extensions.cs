using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFrameWork;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Conteiner
{
    public static class Extensions
    {
        public static void ConteinerDependencies(this IServiceCollection Services)
        {
            Services.AddScoped<IServiceServices, ServiceManager>();
            Services.AddScoped<IServicesDal, EfSErvicesDal>();
            Services.AddScoped<ITeamService, TeamManager>();// ITeamService oluşturulurken TeamManager'i oluştur ve controllerdaki constructor'a TeamManager'i ver. diyoruz.
                                                                    // Eğer bu olmazsa, controller üzerinde ITeamService'yi çağırdığında hangi sınıfı atayacağını sistem bilemez.
            Services.AddScoped<ITeamsDal, EfTeamsDal>();
            Services.AddScoped<IAnnouncementService, AnnounCementManager>();
            Services.AddScoped<IAnnounCemetDal, EFAnnounCementDal>();
            Services.AddScoped<IImageService, ImageManager>();
            Services.AddScoped<IImagesDal, EfImageDal>();
            Services.AddScoped<IAddressService, AddressManager>();
            Services.AddScoped<IAddressDal, EfAddressDal>();
            Services.AddScoped<IContactService, ContactManager>();
            Services.AddScoped<IContactDal, EfContactDal>();
            Services.AddScoped<ISocialMediaService, SocialMediaManager>();
            Services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
            Services.AddScoped<IAboutService, AboutManager>();
            Services.AddScoped<IAboutDal, EfAboutDal>();
            Services.AddScoped<IAdminService, AdminManager>();
            Services.AddScoped<IAdminDal, EfAdminDal>();
        }

    }
}
